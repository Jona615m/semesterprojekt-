/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node
{

  public bool hasItem = true;
  
  public Space (String name) : base(name)
  {
  }

  public bool HasShop { get; set; }
  public bool HasDrop { get; set; }
//indikerer vi har en shop et sted 
  public void Welcome () {
    
    // her bliver der gjort så vi tager vores "exit" udskriver den med vores effekt vi lavede tidligere 

    //Et hashset holder på elementer af en specifik type data i ubesemt rækkefølge.
    //Et hashset bruges til hurtig søgnings og indsætnings operationer.
    HashSet<string> exits = edges.Keys.ToHashSet();

    Util.TypeEffect($"\n{Program.PlayerName}, You can now go to the following route:");
        
    foreach (string exit in exits)
    {
      Util.TypeEffect(" - " + exit); // Effekt og skriver vores "paths" langsommere 
    }
  }
  
  public void Goodbye () {
    // Util.TypeEffect("Goodbye! See you next time!");
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
  //Follow edge kalder super klassens metode - kalder den inde i "Node" klassen


  public void ShowExits()
  {
    HashSet<string> exits = edges.Keys.ToHashSet();

    Util.TypeEffect($"\n{Program.PlayerName}, You can now go to the following route:");
        
    foreach (string exit in exits)
    {
      Util.TypeEffect(" - " + exit); // Effekt og skriver vores "paths" langsommere 
    }
  }


  public GameObject? PickUpObject()
  {
    if(hasItem == false) return null;
    
    this.hasItem = false;
    return Inventory.GetRandomItem();
  }
}
