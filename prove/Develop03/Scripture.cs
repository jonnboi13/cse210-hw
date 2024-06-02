// Scripture.cs

using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private string text;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{reference.GetReferenceText()}\n{GetVisibleScriptureText()}");
    }

    public void HideWords()
    {
        Random random = new Random();

        // Find only the words that are not hidden. Stretch Challenge
        List<int> visibleWordIndices = words.Select((word, index) => new { word, index })
                                             .Where(x => !x.word.IsHidden())
                                             .Select(x => x.index)
                                             .ToList();

        if (visibleWordIndices.Count > 0)
        {
            int indexToHide = visibleWordIndices[random.Next(visibleWordIndices.Count)];
            words[indexToHide].Hide();
        }
    }

    public string GetVisibleScriptureText()
    {
        return string.Join(' ', words.Select(word => word.GetWordText()));
    }

    public bool AreAllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }
}
