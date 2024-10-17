using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("Learning to Code", "CodeAcademy", 300);
        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Jane", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Doe", "Can you make a video about loops?"));

        Video video2 = new Video("Advanced C# Programming", "TechGuru", 600);
        video2.AddComment(new Comment("Alice", "Loved the examples!"));
        video2.AddComment(new Comment("Bob", "Could you explain delegates more?"));

        Video video3 = new Video("Introduction to OOP", "LearnTech", 450);
        video3.AddComment(new Comment("Sam", "OOP is fun!"));
        video3.AddComment(new Comment("Paul", "Can you do an advanced tutorial?"));

        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }

    }
}
