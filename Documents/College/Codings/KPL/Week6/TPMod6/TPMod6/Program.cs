using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    private static readonly Random random = new Random();

    // Constructor
    public SayaTubeVideo(string videoTitle)
    {
        id = random.Next(10000, 99999); // Generate random 5-digit ID
        title = videoTitle;
        playCount = 0;
    }

    // Method to increase play count
    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    // Method to print video details
    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of SayaTubeVideo with title
        string videoTitle = "Tutorial Design By Contract – [NAMA_PRAKTIKAN]";
        SayaTubeVideo video = new SayaTubeVideo(videoTitle);

        // Increase play count
        video.IncreasePlayCount(1); // You can specify any number to increase play count

        // Print video details
        video.PrintVideoDetails();
    }
}
