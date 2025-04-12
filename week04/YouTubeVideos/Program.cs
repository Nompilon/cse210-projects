using System;
using System.Collections.Generic;
class Program
{
    
    static void Main(string[] args)

    {
    //Create 3-4 videos

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Adventure in Peru", "Beyond Travel", 420);
        video1.AddComment(new Comment("Stacy", "This was so beautiful!"));
        video1.AddComment(new Comment("Alice", "Machu Picchu was my favorite place."));
        video1.AddComment(new Comment("John", "Machu Picchu mountain was a beautiful hike."));
        video1.AddComment(new Comment("Charles", "Bucket list was fulfilled today."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 fail of the week", "Jacob.corp", 300);
        video2.AddComment(new Comment("Blademaster", "Wow! @1:30 I hope she didn't get too hurt."));
        video2.AddComment(new Comment("Misty", "Double fail at no.3."));
        video2.AddComment(new Comment("Daniel", "Oh no! Did they take her to the hospital?"));
        video2.AddComment(new Comment("desertrider", "That is hilarious!"));
        videos.Add(video2);

        Video video3 = new Video("How To Make Toast", "Chef Karrine", 1500);
        video3.AddComment(new Comment("Blademaster", "How did I still burn this?!"));
        video3.AddComment(new Comment("Amelia", "This is my new favorite avocado toast."));
        video3.AddComment(new Comment("Lenz", "Wait...so you don't microwave it?"));
        video3.AddComment(new Comment("Toastmaster", "Cheers!"));
        video3.AddComment(new Comment("Derek", "How did you get the fried egg to sit inside the toast and not burn?"));
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(); // Line break between videos
        }
    }
}


public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; } // in seconds
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}

public class Comment
{
    public string Name { get; }
    public string Text { get; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}
<<<<<<< HEAD
=======


    
>>>>>>> cc558b7c7f190c49aa4fa73a652acbaa886445b6
