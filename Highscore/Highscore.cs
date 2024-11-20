namespace temp;

public class Highscore
{
    //Her bliver der fundet vej til txt filen fundet i mappen woz
    private const string HighScoreFile = "/Users/jonasolesen/Desktop/woz/Highscore/HighScores.txt";
    private static List<(string PlayerName, int Point)> HighScores = LoadHighScores();

    //laver en Highscore metode, der gør at HighScores bliver gemt i LoadHighScores
    public static void AddScore(string PlayerName, int Point)
    {
        HighScores.Add((PlayerName, Point));
        HighScores = HighScores.OrderByDescending(x => x.Point).Take(10).ToList();
        //OrderByDescending - gør at scores bliver lavet at højeste score står først og ned til 10'ende
        //Take(10), gør det er top 10
        SaveHighScores();
    }

    public static void DisplayHighscores()
    //Display highscore gør at vi kan kalde den inde i main og vi kan få fremvist den 
    {
        Util.TypeEffect("Top 10 highscores are");
        foreach (var ( PlayerName, Point) in HighScores)
        {
            Util.TypeEffect($"{PlayerName} : {Point}");
        }
    }

    private static List<(string name, int Point)> LoadHighScores()
    {
        if (!File.Exists(HighScoreFile))
            return new List<(string name, int point)>(); //Hvis filen ikke eksisterer, så returnerer den en tom liste

        var lines = File.ReadAllLines(HighScoreFile);
        return lines.Select(line =>
            {
                //var gør at den analyserer om det er en int, string osv.
                var parts = line.Split(" : ");
                return (PlayerName: parts[0], Score: int.Parse(parts[1]));
            }).ToList();
        //parts [0] er spillernavnet
        //parts [1] er scoren
        //int.parse, laver scoren om til et heltal
    }
    //File.WriteAllLines, gør at den gemmer i vores txt fil og den kalder tilbage til "HighScoreFile"
    public static void SaveHighScores()
    {
        var lines = HighScores.Select(x => $"{x.PlayerName} : {x.Point}").ToArray();
        File.WriteAllLines(HighScoreFile, lines);
    }
}