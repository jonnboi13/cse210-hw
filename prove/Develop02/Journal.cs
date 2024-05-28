using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(string content, string prompt)
    {
        Entries.Add(new Entry(content, prompt));
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Content: {entry.Content}");
            Console.WriteLine("--------------------------------------------------");
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            // Check the file extension
            string extension = Path.GetExtension(filename);
            if (extension == ".json")
            {
                // If it's a JSON file, serialize the Entries list to JSON
                string json = JsonConvert.SerializeObject(Entries);
                File.WriteAllText(filename, json);
            }
            else
            {
                // For other file types, save as comma-separated values
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (var entry in Entries)
                    {
                        sw.WriteLine($"{entry.Prompt},{entry.Content},{entry.Date.ToString("MM/dd/yyyy h:mm:ss tt")}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            // Clear the current entries
            Entries.Clear();

            // Read the file content
            string[] lines = File.ReadAllLines(filename);

            // Check the file extension
            string extension = Path.GetExtension(filename);
            if (extension == ".json")
            {
                // If it's a JSON file, deserialize the content to a list of Entry objects
                Entries = JsonConvert.DeserializeObject<List<Entry>>(string.Join("", lines));
            }
            else if (extension == ".txt")
            {
                // If it's a text file, parse each line into a new Entry and add it to the list
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Entries.Add(new Entry
                        {
                            Date = DateTime.Parse(parts[2]),
                            Prompt = parts[0],
                            Content = parts[1]
                        });
                    }
                }
            }
            else
            {
                // If it's neither, print an error message
                Console.WriteLine($"Unsupported file type: {extension}");
            }
        }
        catch (FileNotFoundException)
        {
            // If the file doesn't exist, print an error message
            Console.WriteLine($"File not found: {filename}");
        }
        catch (JsonException)
        {
            // If there's an error in the JSON data, print an error message
            Console.WriteLine($"Error reading data from file: {filename}");
        }
        catch (ArgumentException)
        {
            // If the filename is empty, print an error message
            Console.WriteLine("Filename cannot be empty.");
        }
    }
}