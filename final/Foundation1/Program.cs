using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to hold the videos
        List<Video> videos = new List<Video>();

        // Create some comments
        Comment comment1 = new Comment("BillyBobJoe", "Great video!");
        Comment comment2 = new Comment("MichaelScottSuperFan", "Very informative.");
        Comment comment3 = new Comment("xXFotniteLoverXx", "Loved it!");
        Comment comment4 = new Comment("HarambesSon1394", "Nice explanation.");

        // Create some videos
        Video video1 = new Video("C# Abstraction Tutorial", "TechGuruDaily", 600);
        Video video2 = new Video("C# Encapsulation Tutorial", "CodeWithMasters", 750);
        Video video3 = new Video("C# Inheritance Tutorial", "TheDevLife", 800);
        Video video4 = new Video("C# Polymorphism Tutorial", "ProgrammingInsights", 900);

        // Add comments to the videos
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment4);

        video3.AddComment(comment1);
        video3.AddComment(comment4);
        video3.AddComment(comment3);

        video4.AddComment(comment4);
        video4.AddComment(comment1);
        video4.AddComment(comment2);

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Iterate through the list of videos and display the details
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}
