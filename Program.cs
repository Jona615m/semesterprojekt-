/* Main class for launching the game
 */

using System.Drawing;
using System.Runtime.InteropServices.JavaScript;
using temp;

class Program
{

    public static string PlayerName = "";
    static ZuulShopGame.PlayerShop shop = new ZuulShopGame.PlayerShop();
    static ZuulShopGame.Player player = new ZuulShopGame.Player(0);
    static DateTime startTime = DateTime.Now; // betyder vores start tid begynder fra vores tid og så har man 5 min
    private static TimeSpan duration = TimeSpan.FromMinutes(5);
    public static Quiz quiz = new Quiz();

    private static bool firstRun = true;

    public static void Main(string[] args)
    {
        WelcomeUser();
        World world = new World();
        Space currentSpace = world.GetEntry(); // Set currentSpace til start lokation

        while (true)
        {
            if(firstRun == true)
            {
                firstRun = false;
            } else {
                Console.Clear();
            }

            TimeSpan remainingTime = duration - (DateTime.Now - startTime);
            Console.WriteLine($"\nTime remaining: {remainingTime.Minutes}:{remainingTime.Seconds}");

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
                else if (command == "drop")
                    if (currentSpace.HasDrop)
                {
                    string itemName = input.Substring("drop".Length).Trim(); 
                    bool success = Inventory.RemoveItem(itemName);
                    quiz.Start(itemName);
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
                else if (command == "buy" && inputParts.Length > 1)
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

            Highscore.AddScore(PlayerName, player.Point);
            Util.TypeEffect($"Goodbye! Thanks for playing! \nYour total score is {player.Point} points.");
        }

        static void WelcomeUser()
        {
            Util.TypeEffect("The year is 2057, and the world is drowning in garbage. Huge mountains of " +
                            "trash pile up in every corner of the Earth, and humanity has been forced to retreat into massive" +
                            " underground facilities called EcoHabs. Each EcoHab is a maze of rooms, corridors, and recycling stations " +
                            "designed to manage the relentless tide of garbage. But even these shelters are at their limit!." +
                            "\nWrite your name to begin! ");
            PlayerName = Console.ReadLine();

            // bruger TypeEffect metoed til at printe velkomstbeskeden med effekten
            Util.TypeEffect(
                $"{PlayerName} you are a trash runner! trash runners are tasked with keeping the EcoHabs operational.");

            Util.TypeEffect("\nYour job? Collect as much garbage as possible, throw it into the recycling station, " +
                            "and answer eco-quizzes to sort the trash correctly. " +
                            "But there’s a twist: the garbage spawns faster than ever, and time is running out. " +
                            "You only have 5 minutes to clean your sector before the system overloads!" +
                            "\nPress enter to start your run!");
            Console.ReadLine();

            // Bruges til at skrive resten af velkomst beskeden
            Util.TypeEffect($"\nYour now outside of one of the EcoHabs! " + "\n Type help for commands to use");
        }

    }

