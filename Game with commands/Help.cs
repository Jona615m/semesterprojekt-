namespace temp;

public class Help
{
    public static void HelpCmd()
    {
        Util.TypeEffect("\nYou can now use the following commands:");
        Util.TypeEffect("exit - exits the game");
        Util.TypeEffect("go - gos the next space");
        Util.TypeEffect("pick up - picks up the items at current position");
        Util.TypeEffect("Inventory - shows inventory and player backpack");
        Util.TypeEffect("points - points you got so far!");
        Util.TypeEffect("shop - displays the shop");
        Util.TypeEffect("buy - buys the items for your points!");
        Util.TypeEffect("highscore - shows top 3 scores of the game");
        Util.TypeEffect("map - shows the original map");
        Util.TypeEffect("drop - when you want to drop an item");
    }
}