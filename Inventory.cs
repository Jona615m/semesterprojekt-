public class Inventory
{
    private static List<GameObject> PossibleItems = new List<GameObject>()
    {
        new GameObject("Cigaret", ""),
        new GameObject("Paper", ""),
        new GameObject("Plastic", ""),
        new GameObject("Electronic", ""),
        new GameObject("Snus", ""),
        new GameObject("Metal", ""),
        new GameObject("Glass", ""),
        new GameObject("Cardboard", ""),
        
    };
    
    private static List<GameObject> inventory = new List<GameObject>() {};


    public static GameObject GetRandomItem()
    {
        Random rnd = new Random();
        int number = rnd.Next(PossibleItems.Count);

        try
        {
            return PossibleItems[number];
        }
        catch
        {
            throw new Exception();
        }

    }
    

    // Tilføjer et object til dit inventory
    public static void AddObject(GameObject item)
    {
        inventory.Add(item);
        Util.TypeEffect($"Added {item.name} to your inventory.");
    }
    
    //Fjerner et object fra dit inventory ved hjælp af navn
    public static bool RemoveItem(string itemName)
    {
        GameObject? item = inventory.Find(i => i.name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
        if (item != null)
        {
            inventory.Remove(item);
            Util.TypeEffect($"{itemName} has been removed from your inventory.");
            
            return true;
        }
        Util.TypeEffect($"{itemName} is not in your inventory.");
        return false;
    }

    // Viser alle objecter i dit inventory
    public static void ShowInventory()
    {
        if (inventory.Count > 0)
        {
            Util.TypeEffect("Your inventory contains:");
            foreach (var item in inventory)
            {
                Util.TypeEffect($" - {item.name}: {item.description}");
            }
        }
        else
        {
            Util.TypeEffect("Your inventory is empty.");
        }
    }
    
    //denne metode er til at få en ny "count" på vores item
    public static int GetItemCount()
    {
        return inventory.Count;
    }

    // Checker hvis du har et specifikt item i dit inventory 
    public bool HasItem(string itemName)
    {
        return inventory.Exists(i => i.name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
    }
}