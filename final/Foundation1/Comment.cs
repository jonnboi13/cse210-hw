using System;

public class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    // Method to display the comment details
    public void DisplayComment()
    {
        Console.WriteLine($"{_commenter}: {_text}");
    }
}
