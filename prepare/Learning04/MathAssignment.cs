using System;
using System.Collections.Generic;

public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

     public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _section = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}