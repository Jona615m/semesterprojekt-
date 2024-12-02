namespace temp;

public class Game
{
        private static ZuulShopGame.PlayerShop shop = new ZuulShopGame.PlayerShop();
        private static ZuulShopGame.Player player = new ZuulShopGame.Player(0);
        private static DateTime startTime = DateTime.Now;
        private static TimeSpan duration = TimeSpan.FromMinutes(5);
        public static Quiz quiz = new Quiz();
        private World world;
        private Space currentSpace;

        public Game()
        {
            world = new World();
            currentSpace = world.GetEntry();
        }

        public void RunGame()
        {
            WelcomeUser();

            while (true)
            {
                TimeSpan remainingTime = duration - (DateTime.Now - startTime);
                Console.WriteLine($"\nTime remaining: {remainingTime.Minutes}:{remainingTime.Seconds}");

                Util.TypeEffect($"\nYou are at the {currentSpace.GetName()}.");
                currentSpace.ShowExits();
                string input = Console.ReadLine()?.ToLower();
                string[] inputParts = input?.Split(' ') ?? Array.Empty<string>();
                currentSpace.ItemRespawn(Inventory.GetItemCount());

                if (input == "exit") break;
                if (DateTime.Now - startTime > duration)
                {
                    Util.TypeEffect("\nTime is up!");
                    break;
                }

                ProcessCommand(inputParts);
            }

            Highscore.AddScore(Program.PlayerName, player.Point);
            Util.TypeEffect($"Goodbye! Thanks for playing! \nYour total score is {player.Point} points.");
        }

        private void ProcessCommand(string[] inputParts)
        {
            if (inputParts.Length == 0) return;

            string command = inputParts[0];
            switch (command)
            {
                case "go":
                    if (inputParts.Length > 1) HandleGoCommand(inputParts[1]);
                    break;
                case "pick":
                    if (inputParts.Length >= 2 && inputParts[1] == "up") HandlePickUpCommand();
                    break;
                case "inventory":
                    Inventory.ShowInventory();
                    player.DisplayInventory();
                    break;
                case "help":
                    Help.HelpCmd();
                    break;
                case "points":
                    Util.TypeEffect($"Your total score is {player.Point} points.");
                    break;
                case "drop":
                    HandleDropCommand();
                    break;
                case "shop":
                    HandleShopCommand();
                    break;
                case "buy":
                    if (inputParts.Length > 1) HandleBuyCommand(inputParts[1]);
                    break;
                case "highscore":
                    Highscore.DisplayHighscores();
                    break;
                case "map":
                    DisplayMap();
                    break;
                case "music":
                    HandleMusicCommand();
                    break;
                default:
                    Util.TypeEffect("Invalid command.");
                    break;
            }
        }

        private void HandleGoCommand(string direction)
        {
            Space? nextSpace = currentSpace.FollowEdge(direction);
            if (nextSpace != null)
            {
                if (nextSpace.CanAccess())
                {
                    currentSpace = nextSpace;
                }
                else
                {
                    Util.TypeEffect("This room is locked. You need to unlock it in the shop first.");
                }
            }
            else
            {
                Util.TypeEffect("You can't go that way.");
            }
        }

        private void HandlePickUpCommand()
        {
            GameObject? obj = currentSpace.PickUpObject();
            if (obj == null)
            {
                Util.TypeEffect("There's nothing to pick up.");
            }
            else
            {
                Inventory.AddObject(obj);
                Util.TypeEffect("You picked up: " + obj.name + " and added it to your inventory.");
                player.Point += 100;
            }
            Inventory.ShowInventory();
        }

        private void HandleDropCommand()
        {
            if (currentSpace.HasDrop)
            {
                string itemName = Console.ReadLine()?.Trim();
                bool success = Inventory.RemoveItem(itemName);
                bool correct = quiz.Start(itemName);
                player.Point += correct ? 100 : -100;
            }
        }

        private void HandleShopCommand()
        {
            if (currentSpace.HasShop)
            {
                ZuulShopGame.PlayerShop.DisplayItems();
            }
            else
            {
                Util.TypeEffect("You have to find the shop.");
            }
        }

        private void HandleBuyCommand(string itemName)
        {
            itemName = itemName.ToLower().Trim();
            Util.TypeEffect($"Attempting to buy: {itemName}");
            if (currentSpace.HasShop)
            {
                bool bought = shop.BuyItem(itemName, player);
                if (bought)
                {
                    world.UnlockRoom(itemName);
                }
            }
            else
            {
                Util.TypeEffect("You need to be in a shop to buy items.");
            }
        }

        private void HandleMusicCommand()
        {
            try
            {
                temp.Easteregg.Easteregg.Music();
            }
            catch (Exception e)
            {
                Console.WriteLine("WHOMP WHOMP"); 
            }
        }

        private void DisplayMap()
        {
            string currentMap = Program.GetCurrentMap(world);
            Console.WriteLine(currentMap);
            Util.TypeEffect("Press enter to continue.");
            Console.ReadLine();
        }

        private void WelcomeUser()
        {
            
            {
                Util.TypeEffect("The year is 2057, and the world is drowning in garbage. Huge mountains of " +
                                "trash pile up in every corner of the Earth, and humanity has been forced to retreat into massive" +
                                " underground facilities called EcoHabs. Each EcoHab is a maze of rooms, corridors, and recycling stations " +
                                "designed to manage the relentless tide of garbage. But even these shelters are at their limit!." +
                                "\nWrite your name to begin! ");
                Program.PlayerName = Console.ReadLine();

                // bruger TypeEffect metoed til at printe velkomstbeskeden med effekten
                Util.TypeEffect(
                    $"{Program.PlayerName} you are a trash runner! trash runners are tasked with keeping the EcoHabs operational.");

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
    }
