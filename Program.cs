/* Main class for launching the game
 */

using System.Drawing;
using System.Runtime.InteropServices.JavaScript;
using temp;

class Program
{
    public static string PlayerName = "";

    //Her går den ind og læser map klassen og også vores world class
    public static string GetCurrentMap(World world)
    {
        bool room1Unlocked = world.Room1.HasAccess;
        bool room2Unlocked = world.Room2.HasAccess;

        if (room1Unlocked && room2Unlocked)
        {
            return Map.BothRoomsUnlockedMap; //
        }
        else if (room1Unlocked)
        {
            return Map.Room1UnlockedMap;
        }
        else if (room2Unlocked)
        {
            return Map.Room2UnlockedMap;
        }
        else
        {
            return Map.DefaultMap;
        }
    }

    public static void Main(string[] args)
    {
        Game Play = new Game();
        Play.RunGame();
    }
}

