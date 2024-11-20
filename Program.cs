/* Main class for launching the game
 */

using System.Drawing;
using System.Runtime.InteropServices.JavaScript;
using temp;
class Program {

  public static string PlayerName = "";
  static ZuulShopGame.PlayerShop shop = new ZuulShopGame.PlayerShop();
  static ZuulShopGame.Player player = new ZuulShopGame.Player(Point);
  static DateTime startTime = DateTime.Now; // betyder vores start tid begynder fra vores tid og så har man 5 min
  private static TimeSpan duration = TimeSpan.FromMinutes(0.2);
  public static int Point { get; set; }
  
  public static void Main (string[] args)
  {
    WelcomeUser();
        World world = new World();
        Space currentSpace = world.GetEntry(); // Set currentSpace til start lokation
        
        while (true)
        
        {
            Util.TypeEffect($"\nYou are at the {currentSpace.GetName()}.");
            currentSpace.ShowExits();
            string input = Console.ReadLine()?.ToLower();
            string[] inputParts = input?.Split(' ') ?? Array.Empty<string>();

            if (input == "exit") break;
            if (DateTime.Now - startTime > duration)
            {
                Util.TypeEffect("\nTime i up!");
                break;
            }
            
            TimeSpan remainingTime = duration - (DateTime.Now - startTime);
            Console.WriteLine($"\nTime remaining: {remainingTime.Minutes}:{remainingTime.Seconds}");
            
            if (inputParts.Length > 0)
            {
                string command = inputParts[0];

                if (command == "go" && inputParts.Length > 1)
                {
                    string direction = inputParts[1];
                    Space? nextSpace = currentSpace.FollowEdge(direction); // Follow edge til den næste "space"
                    if (nextSpace != null) 
                    {
                        currentSpace = nextSpace; // Opdaterer din lokation nu
                        Util.TypeEffect($"You moved to {currentSpace.GetName()}.");
                    }
                }
                else if (command == "pick" && inputParts.Length >= 2 && inputParts[1] == "up")
                {
                    //string objectName = input.Substring("pick up ".Length);
                    GameObject? obj = currentSpace.PickUpObject();
                    if (obj == null)
                    {
                        Util.TypeEffect("Theres nothing to pick up");
                    }
                    else
                    {
                        Inventory.AddObject(obj);
                        Util.TypeEffect("You picked up: " + obj.name + " and added it to your inventory.");
                        player.Point += 100;
                    }

                    Inventory.ShowInventory();
                }
                else if (command == "inventory")
                {
                    Inventory.ShowInventory(); //Display inventory
                    player.DisplayInventory(); //Display player inventory
                }
                else if (command == "help")
                {
                    Help.HelpCmd();
                }
                else if (command == "points")
                {
                    Util.TypeEffect($"Your total score is {player.Point} points.");
                }
                else if (command == "shop")
                    if (currentSpace.HasShop)
                {
                    ZuulShopGame.PlayerShop.DisplayItems();
                }
                else
                {
                    Util.TypeEffect($"You have to find the shop");
                    
                }
                else if (command == "buy" && inputParts.Length >1)
                {
                    string itemName = input.Substring("buy".Length).ToLower().Trim();
                    Util.TypeEffect($"Attempting to buy: {itemName}");
                    if (currentSpace.HasShop)
                    {
                        shop.BuyItem(itemName, player);
                    }
                    else
                    {
                        Util.TypeEffect($"You have to find the shop, before you can buy items");
                    }
                 //forsøger at købe items
                }
                else if (command == "highscore")
                {
                    Highscore.DisplayHighscores();
                }
                
                else
                {
                    Util.TypeEffect("Invalid command.");
                }
            }
        }
      
        Util.TypeEffect($"Goodbye! Thanks for playing! \nYour total score is {player.Point} points.");
    }
  static void WelcomeUser() {
      Util.TypeEffect("Hello my friend! welcome to the park, can you please enter your name?");
      PlayerName = Console.ReadLine();

      // bruger TypeEffect metoed til at printe velkomstbeskeden med effekten
      Util.TypeEffect($"Welcome {PlayerName}! Are you ready to learn something about recycling your world?");

      Util.TypeEffect("\nPress Enter to continue ... your journey");
      Console.ReadLine();

      // Bruges til at skrive resten af velkomst beskeden
      Util.TypeEffect($"\nYour now outside at the park" + "\n Type help for commands to use");
  }
  
}
