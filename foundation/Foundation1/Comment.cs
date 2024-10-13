public class Comment
{
    // Attributes of the Comment class
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    // Method to display the comment
    public void DisplayComment()
    {
        Console.WriteLine($"{CommenterName}: \"{CommentText}\"");
    }
}
