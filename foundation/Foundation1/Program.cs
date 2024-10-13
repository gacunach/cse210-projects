using System;

class Program
{
    static void Main(string[] args)
    {
       public class Comment
{
    
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

   
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    
    public void DisplayComment()
    {
        Console.WriteLine($"{CommenterName}: \"{CommentText}\"");
    }
}

    }
}
