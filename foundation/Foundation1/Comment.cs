public class Comment
{
    
    public string _commenterName { get; set; }
    public string _commentText { get; set; }

    
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

   
    public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName}: \"{_commentText}\"");
    }
}
