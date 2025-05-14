using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

interface IMusicPlayer
{
    void Play(string song);
    void Pause();
    void Stop();
}
class SpotifyPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine("Playing "+song+" on Spotify");
    }
    public void Pause()
    {
        Console.WriteLine("Spotify playback paused");
    }
    public void Stop()
    {
        Console.WriteLine("Spotify playback stopped");
    }
}
class AppleMusicPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine("Playing " + song + " on Apple Music");
    }
    public void Pause()
    {
        Console.WriteLine("Apple Music playback paused");
    }
    public void Stop()
    {
        Console.WriteLine("Apple Music playback stopped");
    }
}
class Program
{
    static void Main()
    {
        IMusicPlayer spotify=new SpotifyPlayer();
        spotify.Play("See you again");
        spotify.Pause();
        spotify.Stop();

        IMusicPlayer applemusic = new AppleMusicPlayer();
        applemusic.Play("Levitating");
        applemusic.Pause();
        applemusic.Stop();
    }

}




