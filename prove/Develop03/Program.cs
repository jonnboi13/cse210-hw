using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string book = "John";
        int chapter = 3;
        List<int> verses = new List<int> { 16, 18, 21 };
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference reference = new Reference(book, chapter, verses);
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.DisplayScripture();
            Console.Write("Type 'exit' to quit or press Enter to continue: ");
            string command = Console.ReadLine().Trim().ToLower();
            if (command == "exit" || scripture.AreAllWordsHidden())
            {
                break;
            }
            scripture.HideWords(3);
            Console.WriteLine("\n");
        }
    }
}
