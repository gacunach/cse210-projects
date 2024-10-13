using System;
using System.Collections.Generic;

public class Video
{
    // Attributes of the Video class
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // In seconds
    private List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to display video details and its comments
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine(); // Add space between videos
    }
}
