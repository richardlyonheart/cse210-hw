using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos = new List<Video> ();
        Console.Clear();
        
        Video video1 = new Video("How to make jeans", "James Dean", "60m");
        video1.AddComment("John Doe", "Why would I watch this?");
        video1.AddComment("John Smith", "CGI");
        video1.AddComment("John John", "I prefer to use the method of working wool with my teeth");
        videos.Add(video1);

        Video video2 = new Video("Who Is this man", "Anonymous", "3m 45s");
        video2.AddComment("John Doe", "I seen him on the 45 south.");
        video2.AddComment("John Smith", "I think he was incredible to help this way");
        video2.AddComment("John John", "CGI");
        videos.Add(video2);

        Video video3 = new Video("Punch a log", "Youtubeman", "2m 30s");
        video3.AddComment("Bob Cracthet", "NEVER GIVE UP SAILORS");
        video3.AddComment("Chuck Norris", "It's a great blessing.");
        video3.AddComment("Steve Rogers", "I can do this all day");
        video3.AddComment("Iron Man", "I am Iron Man");
        videos.Add(video3);

        
        foreach(Video video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine($"Number of Comments: {video.GetCommentNumber()} \n");
            video.DisplayComments();
        }
    }
}