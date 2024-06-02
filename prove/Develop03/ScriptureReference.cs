// Reference.cs

public class Reference
{
    private string bookName;
    private int chapter;
    private List<int> verses;

    public Reference(string bookName, int chapter, List<int> verses)
    {
        this.bookName = bookName;
        this.chapter = chapter;
        this.verses = verses;
    }

    public string GetReferenceText()
    {
        string versesText = string.Empty;

        if (verses.Count > 1)
        {
            int startVerse = verses[0];
            int endVerse = verses[verses.Count - 1];

            if (endVerse - startVerse == verses.Count - 1)
            {
                // Verses are consecutive
                versesText = $"{startVerse}-{endVerse}";
            }
            else
            {
                // Verses are not consecutive
                versesText = string.Join(", ", verses);
            }
        }
        else if (verses.Count == 1)
        {
            versesText = verses[0].ToString();
        }

        return $"{bookName} {chapter}:{versesText}";
    }

    public string GetBookName()
    {
        return bookName;
    }

    public int GetChapterNumber()
    {
        return chapter;
    }

    public List<int> GetVerseNumbers()
    {
        return verses;
    }
}
