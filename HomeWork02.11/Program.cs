using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<MultimediaPlayer> players = new List<MultimediaPlayer>()
        {
            new AudioPlayer("Sony Walkman","Audio Player",true),
            new VideoPlayer("Samsun Galaxy Tab", "Tablet with Video Player" ,10.1),
            new YouTubePlayer("LG Smart TV","Smart TV with YouTube App", "Full HD")
        };

        foreach (var player in players) 
        {
            System.Console.WriteLine($"Device : {player.Brand} - {player.Model}");
            player.Play();
            player.Pause();
            player.Stop();
            player.DisplayInfo();
            System.Console.WriteLine();
        }
    }
}

abstract class MultimediaPlayer
{
    public string Brand { get; }
    public string Model { get; }

    public MultimediaPlayer(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public abstract void Play();
    public abstract void Pause();
    public abstract void Stop();
    public abstract void DisplayInfo();
}
interface IMediaPlayable
{
    void Play();
}

class AudioPlayer : MultimediaPlayer, IMediaPlayable
{
    public bool HasSpeakers { get; }

    public AudioPlayer(string brand, string model, bool hasSpeakers):base(brand, model)
    {
        HasSpeakers = hasSpeakers;
    }
    public override void Play()
    {
        System.Console.WriteLine("Playing audio...");
    }
    public override void Pause()
    {
        System.Console.WriteLine("Pausing audio...");
    }
    public override void Stop()
    {
        System.Console.WriteLine("Stopping audio...");
    }
    public override void DisplayInfo()
    {
       System.Console.WriteLine($"Audio Player Info: Has Speakers - {HasSpeakers}");
    }
}
class VideoPlayer : MultimediaPlayer, IMediaPlayable
{
    public double ScreenSizeInInches { get; }

    public VideoPlayer(string brand, string model, double screenSizeInInches)
        : base(brand, model)
    {
        ScreenSizeInInches = screenSizeInInches;
    }
    public override void Play()
    {
        Console.WriteLine("Playing video...");
    }

    public override void Pause()
    {
        Console.WriteLine("Pausing video...");
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping video...");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Video Player Info: Screen Size - {ScreenSizeInInches} inches");
    }
}
class YouTubePlayer : MultimediaPlayer, IMediaPlayable
{
    public string VideoResolution { get; }

    public YouTubePlayer(string brand, string model, string videoResolution) : base(brand, model)
    {
        VideoResolution = videoResolution;
    }
    public override void Play()
    {
        Console.WriteLine("Streaming YouTube video...");
    }

    public override void Pause()
    {
        Console.WriteLine("Pausing YouTube video...");
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping YouTube video...");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"YouTube Player Info: Video Resolution - {VideoResolution}");
    }
}