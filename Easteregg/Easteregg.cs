using NAudio.Wave;
using System.Diagnostics;
namespace temp.Easteregg;
public class Easteregg
{
    public static void Music()
    {
        // finder filerne igennem domænet woz/bin/debugg/net8/easteregg
        string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Easteregg", "rickroll.mp3");
        try
        {
            // Checker om filen findes
            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine($"What is this?");
                return;
            }

            Console.WriteLine("You just got RICK ROLLED");

            //bruger afplay til at spille filen
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "afplay",       // macOS command til afspilning af audio
                    Arguments = $"\"{filePath}\"", // Filen til at afspille
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    UseShellExecute = false
                }
            };

            process.Start();
            process.WaitForExit(); //gør filen skal spille færdig før spilleren kan forsætte
        }
        catch (Exception e)
        {
            Console.WriteLine($"Whomp whomp");
        }
    }
}