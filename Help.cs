namespace temp;

public class Help
{
    public static void HelpCmd()
    {
        Util.TypeEffect("\nYou can now use the following commands:");
        Util.TypeEffect("exit - exits the game");
        Util.TypeEffect("go - gos the next space");
        Util.TypeEffect("pick up - picks up the items at current position");
        Util.TypeEffect("points - points you got so far!");
        Util.TypeEffect("shop - displays the shop");
        Util.TypeEffect("buy - buys the items for your points!");
    }
}