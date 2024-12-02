using NAudio.Wave;
using System.Diagnostics;


namespace temp.Easteregg;

public class Easteregg
{
    public static void Music()
    {
        string filePath = @"/Users/jonasolesen/Desktop/woz/Easteregg/rickroll.mp3";
        try
        {
            // Check if file exists
            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            Console.WriteLine("Playing music using afplay...");

            // Use afplay to play the file
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "afplay",       // macOS command to play audio
                    Arguments = $"\"{filePath}\"", // File to play
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    UseShellExecute = false
                }
            };

            process.Start();
            process.WaitForExit(); // Wait for the process to finish playing the file
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error playing music: {e.Message}");
        }
    }
}