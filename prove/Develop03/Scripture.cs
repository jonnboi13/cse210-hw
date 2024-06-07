// Scripture.cs

using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._text = text;
        this._words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.GetReferenceText()}\n{GetVisibleScriptureText()}");
    }

    public void HideWords(int numberOfWordsToHide)
    {
        Random random = new Random();

        // Find only the words that are not hidden.
        List<int> visibleWordIndices = _words.Select((word, index) => new { word, index })
                                             .Where(x => !x.word.IsHidden())
                                             .Select(x => x.index)
                                             .ToList();

        // Hide 'numberOfWordsToHide' words at a time
        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            if (visibleWordIndices.Count > 0)
            {
                int randomIndex = random.Next(visibleWordIndices.Count);
                int wordIndexToHide = visibleWordIndices[randomIndex];
                _words[wordIndexToHide].Hide();
                visibleWordIndices.RemoveAt(randomIndex);
            }
        }
    }

    public string GetVisibleScriptureText()
    {
        return string.Join(' ', _words.Select(word => word.GetWordText()));
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
