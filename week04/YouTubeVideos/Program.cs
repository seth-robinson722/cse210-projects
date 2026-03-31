using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store the videos
            List<Video> videos = new List<Video>();

            // --- Video 1 ---
            Video video1 = new Video("C# Interfaces Explained", "ProgrammingWithMosh", 600);
            video1.AddComment(new Comment("Alice", "Great explanation, very clear!"));
            video1.AddComment(new Comment("Bob", "I finally understand Abstraction now."));
            video1.AddComment(new Comment("Charlie", "Can you do a video on Unit Testing?"));
            videos.Add(video1);

            // --- Video 2 ---
            Video video2 = new Video("10 Minute Morning Yoga", "YogaWithAdriene", 600);
            video2.AddComment(new Comment("Dave", "Perfect start to my day."));
            video2.AddComment(new Comment("Eve", "Love the pacing of this routine."));
            video2.AddComment(new Comment("Frank", "My back feels so much better. Thanks!"));
            videos.Add(video2);

            // --- Video 3 ---
            Video video3 = new Video("The Best Chocolate Cake Recipe", "BakingPro", 450);
            video3.AddComment(new Comment("Grace", "Mine came out a bit dry, what did I do wrong?"));
            video3.AddComment(new Comment("Heidi", "Best cake I've ever made. Hands down."));
            video3.AddComment(new Comment("Ivan", "I added a bit of espresso powder, amazing!"));
            video3.AddComment(new Comment("Judy", "Made this for a birthday and it was a hit."));
            videos.Add(video3);

            // Iterate through the list and display the information
            foreach (Video video in videos)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Title: {video._title}");
                Console.WriteLine($"Author: {video._author}");
                Console.WriteLine($"Length: {video._length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("\nComments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment._name}: \"{comment._text}\"");
                }
                Console.WriteLine("--------------------------------------------------\n");
            }
        }
    }
}