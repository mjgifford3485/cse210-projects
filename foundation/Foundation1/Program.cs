using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Programming with Classes", "Mike Jones", 650);
        v1.AddComment(new Comment("Joe", "Very Informative!"));
        v1.AddComment(new Comment("Bob", "Really well done!"));
        v1.AddComment(new Comment("Charlie", "I can finally program with classes!"));
        videos.Add(v1);

        Video v2 = new Video("Abstraction", "Betty White", 1820);
        v2.AddComment(new Comment("Jane", "Thank you!"));
        v2.AddComment(new Comment("Alice", "Not the best video I've seen"));
        v2.AddComment(new Comment("Susan", "Still a little fuzzy."));
        videos.Add(v2);

        Video v3 = new Video("Encapsulation", "Sara Varnes", 280);
        v3.AddComment(new Comment("Jim", "Too short."));
        v3.AddComment(new Comment("Jill", "Just long enough"));
        v3.AddComment(new Comment("Jack", "Too long"));
        videos.Add(v3);

        foreach(Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length {video._length}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments: ");

            foreach(Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment._commenterName}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}