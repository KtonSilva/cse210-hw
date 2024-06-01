using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Use a relative path to the videos.txt file
        string fileName = "videos.txt";
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        // Read videos from the text file
        List<Video> videos = ReadVideosFromFile(filePath);

        // Display information for each video
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }

    static List<Video> ReadVideosFromFile(string filePath)
    {
        List<Video> videos = new List<Video>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            Video currentVideo = null;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                if (line.StartsWith("---"))
                {
                    if (currentVideo != null)
                    {
                        videos.Add(currentVideo);
                    }
                    currentVideo = null;
                }
                else
                {
                    if (currentVideo == null)
                    {
                        string title = line;
                        string author = lines[++i];
                        int length = int.Parse(lines[++i]);
                        currentVideo = new Video(title, author, length);
                    }
                    else
                    {
                        string commenterName = line;
                        string text = lines[++i];
                        currentVideo.AddComment(new Comment(commenterName, text));
                    }
                }
            }

            if (currentVideo != null)
            {
                videos.Add(currentVideo);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return videos;
    }
}
