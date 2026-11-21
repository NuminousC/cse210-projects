using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create four videos. Each Video object stores its own Comment objects.
        Video video1 = new Video("Learning C# Classes", "Code with Alex", 625);
        video1.AddComment(new Comment("Maya", "The examples made classes easier to understand."));
        video1.AddComment(new Comment("Daniel", "I finally understand constructors."));
        video1.AddComment(new Comment("Grace", "Please make another lesson about objects."));

        Video video2 = new Video("A Beginner's Guide to Git", "Dev Steps", 480);
        video2.AddComment(new Comment("Samuel", "This helped me understand commits."));
        video2.AddComment(new Comment("Aisha", "The explanation was clear and practical."));
        video2.AddComment(new Comment("Peter", "I would like to see a lesson about branches."));

        Video video3 = new Video("Building Better Study Habits", "Learn Every Day", 735);
        video3.AddComment(new Comment("Ruth", "The small daily goals are useful."));
        video3.AddComment(new Comment("John", "I am going to try the weekly review."));
        video3.AddComment(new Comment("Esther", "A very encouraging video."));

        Video video4 = new Video("Understanding Object Composition", "Programming Simply", 590);
        video4.AddComment(new Comment("David", "The real-life examples were helpful."));
        video4.AddComment(new Comment("Joy", "Composition makes more sense now."));
        video4.AddComment(new Comment("Michael", "Thank you for keeping it beginner friendly."));

        // Store all Video objects in one list.
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display each video and the comments stored inside it.
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLengthInSeconds() + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("- " + comment.GetCommenterName() + ": " + comment.GetText());
            }

            Console.WriteLine();
        }
    }
}
