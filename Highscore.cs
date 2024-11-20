namespace temp;

public class Highscore
{
    private const string HighScoreFile = @"C:/Users/jonasolesen/Desktop/woz/HighScores.txt";
    private static List<(string PlayerName, int Point)> HighScores;

    public Highscore()
    {
        HighScores = LoadHighScores();
    }

    public void AddScore(string PlayerName, int Point)
    {
        HighScores.Add((PlayerName, Point));
        HighScores = HighScores.OrderByDescending(x => x.Point).Take(10).ToList();
        SaveHighScores();
    }

    public static void DisplayHighscores()
    {
        Util.TypeEffect("Top 10 highscores are");
        foreach ((var playerName, Point) in HighScores)
        {
            Util.TypeEffect($"{playerName} : {Point}");
        }
    }

    private List<(string name, int Point)> LoadHighScores()
    {
        if (!File.Exists(HighScoreFile))
            return new List<(string name, int point)>(); //Hvis filen ikke eksisterer, så returnerer den en tom liste

        var lines = File.ReadAllLines(HighScoreFile);
        return lines
            .Select(line =>
            {
                var parts = line.Split(',');
                return (PlayerName: parts[0], Score: int.Parse(parts[1]));
            }).ToList();
        //parts [0] er spillernavnet
        //parts [1] er scoren
        //int.parse, laver scoren om til et heltal
    }

    public void SaveHighScores()
    {
        var lines = HighScores.Select(x => $"{x.PlayerName} : {x.Point}").ToArray();
        File.WriteAllLines(HighScoreFile, lines);
    }
}