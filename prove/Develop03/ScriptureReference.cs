public class Reference
{
    private string _bookName;
    private int _chapter;
    private List<int> _verses;

    public Reference(string bookName, int chapter, List<int> verses)
    {
        this._bookName = bookName;
        this._chapter = chapter;
        this._verses = verses;
    }

    public string GetReferenceText()
    {
        string versesText = string.Empty;

        if (_verses.Count > 1)
        {
            int startVerse = _verses[0];
            int endVerse = _verses[_verses.Count - 1];

            if (endVerse - startVerse == _verses.Count - 1)
            {
                // Verses are consecutive
                versesText = $"{startVerse}-{endVerse}";
            }
            else
            {
                // Verses are not consecutive
                versesText = string.Join(", ", _verses);
            }
        }
        else if (_verses.Count == 1)
        {
            versesText = _verses[0].ToString();
        }

        return $"{_bookName} {_chapter}:{versesText}";
    }

    public string GetBookName()
    {
        return _bookName;
    }

    public int GetChapterNumber()
    {
        return _chapter;
    }

    public List<int> GetVerseNumbers()
    {
        return _verses;
    }
}
