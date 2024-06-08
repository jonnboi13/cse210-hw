public class Word
{
    private string _wordToDrop;
    private bool _isHidden;

    public Word(string wordText)
    {
        _wordToDrop = wordText;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Reveal()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetWordText()
    {
        if (_isHidden)
        {
            return new string('_', _wordToDrop.Length);
        }
        return _wordToDrop;
    }
}
