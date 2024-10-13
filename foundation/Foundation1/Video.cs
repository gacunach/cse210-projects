using System;
using System.Collections.Generic;

public class Video
{
    
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; } 
    private List<Comment> _comments { get; set; }

    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}
