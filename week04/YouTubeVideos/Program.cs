using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video();
        video1._title = "Every single feature of C# in 10 minutes";
        video1._author = "Train To Code";
        video1._length = 589;
        
        Comment comment1 = new Comment();
        comment1._commenter = "@Banaaani";
        comment1._comment = "I have used C# for roughly 5 years now, and I still learned something new!";
        video1._comments.Add(comment1);

        Comment comment2 = new Comment();
        comment2._commenter = "@WayneGreen-g8l";
        comment2._comment = "I've been programming in C# since 2006, and this video had a few things I had forgotten. Thanks.";
        video1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._commenter = "@MsFm2000";
        comment3._comment = "The best ten minutes of education I've had in a while.";
        video1._comments.Add(comment3);

        Comment comment4 = new Comment();
        comment4._commenter = "@MrThezyga";
        comment4._comment = "I'm learning C# as another language after Python and this video was exactly what I was looking for, thanks";
        video1._comments.Add(comment4);

        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "SOLID Principles Explained - C# Example";
        video2._author = "Code Academy";
        video2._length = 720;

        Comment comment5 = new Comment();
        comment5._commenter = "@DevJane";
        comment5._comment = "These principles changed the way I write code!";
        video2._comments.Add(comment5);

        Comment comment6 = new Comment();
        comment6._commenter = "@CoderGuy90";
        comment6._comment = "Great breakdown of the principles. Easy to follow.";
        video2._comments.Add(comment6);

        Comment comment7 = new Comment();
        comment7._commenter = "@ObjectOrientedQueen";
        comment7._comment = "The 'Single Responsibility Principle' finally makes sense!";
        video2._comments.Add(comment7);

        Comment comment8 = new Comment();
        comment8._commenter = "@BeginnerCoder101";
        comment8._comment = "I wish I saw this video earlier. Thanks!";
        video2._comments.Add(comment8);

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "How to debug like a pro | Visual Studio Tips";
        video3._author = "Debug Ninja";
        video3._length = 505;

        Comment comment9 = new Comment();
        comment9._commenter = "@DebugMaster";
        comment9._comment = "This was exactly what I needed. Amazing content.";
        video3._comments.Add(comment9);

        Comment comment10 = new Comment();
        comment10._commenter = "@StackTraceLover";
        comment10._comment = "I always struggled with breakpoints—now it’s clear!";
        video3._comments.Add(comment10);

        Comment comment11 = new Comment();
        comment11._commenter = "@BugHunter23";
        comment11._comment = "Tip #3 saved me hours of frustration.";
        video3._comments.Add(comment11);

        Comment comment12 = new Comment();
        comment12._commenter = "@CodeTherapist";
        comment12._comment = "Every developer should watch this at least once.";
        video3._comments.Add(comment12);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }

    }
}