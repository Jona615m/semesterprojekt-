namespace temp;

public class ZuulShopGame
{
    
    // Klassen Item er for en genstand i spillet
    public class ShopItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }

        // starten til at initialisere Item med navn, beskrivelse og pris
        public ShopItem(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }

    // Klassen Shop repræsenterer butikken, hvor spilleren kan købe og sælge genstande
    public class PlayerShop
    {
        // Dictionary til at gemme genstande til salg, med navn som nøgle
        public static Dictionary<string, ShopItem> ItemsForSale { get; private set; }

        // Konstruktør initialiserer listen af genstande, der kan købes i butikken
        public PlayerShop()
        {
            // Her laver jeg listen af forskellige ting i shoppen
            ItemsForSale = new Dictionary<string, ShopItem>
            {
                { "", new ShopItem("", ".", 50) },
                { "spawnrate", new ShopItem("Spawnrate", "Higher spawnrate for trash.", 100) },
                { "door", new ShopItem("Door", "Unlocks a new room", 150) }
            };
        }

        // Metode til at vise alle tilgængelige genstande i butikken
        public static void DisplayItems()
        {
            Util.TypeEffect("Welcome to the trash shop");
            foreach (var item in ItemsForSale)
            {
                Util.TypeEffect($"{item.Key}: {item.Value.Name} - {item.Value.Description} - {item.Value.Price} point");
            }
        }

        // Metode til at købe en genstand, hvis spilleren har nok point
        public  bool BuyItem(string itemName, Player player)
        {
            // Tjekker om genstanden findes i butikken
            if (ItemsForSale.ContainsKey(itemName))
            {
                ShopItem item = ItemsForSale[itemName];
                // Tjekker om spilleren har nok point til at købe genstanden
                if (player.Point >= item.Price)
                {
                    player.AddItem(item); // Tilføjer genstanden til spillerens inventar
                    player.Point -= item.Price; // Trækker prisen fra spillerens point
                    Util.TypeEffect($"You bought a {item.Name} for {item.Price} points.");
                    return true;
                }
                else
                {
                    Util.TypeEffect("You don't have enough points!");
                }
            }
            else
            {
               Util.TypeEffect("That item is not available.");
            }

            return false;
        }

        /*
        // Metode til at sælge en genstand fra spillerens inventar
        public bool SellItem(string itemName, Player player)
        {
            ShopItem item = player.RemoveItem(itemName); // Fjerner genstanden fra inventaret
            if (item != null)
            {
                int sellPrice = item.Price / 2; // Sælger genstanden for halv pris
                player.Point += sellPrice; // Tilføjer salgsprisen til spillerens point
                Console.WriteLine($"You sold your {item.Name} for {sellPrice} points.");
                return true;
            }
            else
            {
                Console.WriteLine("You don't have that item to sell.");
            }

            return false;
        }*/
    }

    // Klassen Player repræsenterer spilleren, som kan have point og et inventar
    public class Player
    {
        public int Point { get; set; }
        private Dictionary<string, ShopItem> Inventory { get; set; }

        // Konstruktør initialiserer spilleren med en startmængde point og et tomt inventar
        public Player(int startingPoint)
        {
            Point = startingPoint;
            Inventory = new Dictionary<string, ShopItem>();
        }

        // Metode til at tilføje en genstand til spillerens inventar
        public void AddItem(ShopItem item)
        {
            Inventory[item.Name.ToLower()] = item;
            Console.WriteLine($"You added {item.Name} to your inventory.");
        }

        // Metode til at fjerne en genstand fra inventaret og returnere den, hvis den findes
        /*public ShopItem RemoveItem(string itemName)
        {
            if (Inventory.ContainsKey(itemName))
            {
                ShopItem item = Inventory[itemName];
                Inventory.Remove(itemName);
                return item;
            }

            return null;
        }*/

        // Metode til at vise alle genstande i spillerens inventar
        public void DisplayInventory()
        {
            Util.TypeEffect("\nYour player backpack:");
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Empty.");
                return;
            }

            foreach (var item in Inventory.Values)
            {
                Util.TypeEffect($"{item.Name}: {item.Description}");
            }
        }
    }
}