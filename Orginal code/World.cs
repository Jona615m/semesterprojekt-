/* Worldclass for modeling the entire in-game world
 */

using temp;

class World {
  public bool IsRoom1Unlocked()
  {
    return Room1.HasAccess;
  }

  public bool IsRoom2Unlocked()
  {
    return Room2.HasAccess;
  }
  public Space Haven { get; }
  public Space Room1 { get;}
  public Space Room2 { get; }
  
  public World () {
    Space Haven        = new Space("haven");
    Space Nexus        = new Space("nexus");
    Space Hub          = new Space("hub");
    Space Core         = new Space("core");
    Space Farm         = new Space("farm");
    Space Recycle      = new Space("station") { HasDrop = true} ;
    Space Shop         = new Space("shop") { HasShop = true };
    Room1        = new Space("room1") {HasAccess = false, IsVisble = false};
    Room2        = new Space("room2") { HasAccess = false, IsVisble = false};
    
    Haven.AddEdge("nexus", Nexus);

    Nexus.AddEdge("hub", Hub);
    //path.AddObject();
    
    Hub.AddEdge("core", Core);
    Hub.AddEdge("playground", Farm);
    Hub.AddEdge("station", Recycle);
    Hub.AddEdge("room1", Room1);
    
    Room1.AddEdge("room2", Room2);
    Room1.AddEdge("hub", Hub);
    
    Room2.AddEdge("room1", Room1);
    Room2.AddEdge("station", Recycle);

    Core.AddEdge("hub", Hub);
    Core.AddEdge("shop", Shop);
    //forest.AddObject();
    
    Farm.AddEdge("hub", Hub);

    Recycle.AddEdge("hub", Hub);
    Recycle.AddEdge("shop", Shop);
    Recycle.AddEdge("room2", Room2);
    
    Shop.AddEdge("core", Core);
    Shop.AddEdge("station", Recycle);
    
    this.Haven = Haven;
    
  }
  
  public Space GetEntry () {
    return Haven;
  }
  //Her har vi lavet en metode med switch case, som gør at når vi køber et rum,
  //så searcher den igennem for at se om vi har unlocked vores rum
  public void UnlockRoom(string roomName)
  {
    switch (roomName)
    {
      case "room1":
        Room1.HasAccess = true;
        Room1.IsVisble = true;
        break;
      case "room2":
        Room2.HasAccess = true;
        Room2.IsVisble = true;
        break;
      default:
        Util.TypeEffect("no room with that name to unlock.");
        return;
    }

    Util.TypeEffect($"Unlocked: {roomName}");
  }
  
}
