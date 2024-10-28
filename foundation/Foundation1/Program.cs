using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("Introduction to C#", "CodeAcademy", 3600);
        Video video2 = new Video("Cooking with Gordon Ramsay", "Gordon Ramsay", 1800);
        Video video3 = new Video("Exploring the Amazon Rainforest", "National Geographic", 7200);

        // Add comments to the videos
        video1.Comments.Add(new Comment("John Doe", "Great video!"));
        video1.Comments.Add(new Comment("Jane Doe", "Very informative."));
        video2.Comments.Add(new Comment("Alice Smith", "Delicious!"));
        video2.Comments.Add(new Comment("Bob Johnson", "Can't wait to try this."));
        video3.Comments.Add(new Comment("Charlie Brown", "Amazing scenery!"));
        video3.Comments.Add(new Comment("David Lee", "So much to learn about the rainforest."));

        // Create a list of videos
        List<Video> videos = new List<Video>() { video1, video2, video3 };

        // Iterate through the list of videos and display their information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");   

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}