/* Worldclass for modeling the entire in-game world
 */

class World {
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
    Hub.AddEdge("room2", Room2);

    Core.AddEdge("hub", Hub);
    Core.AddEdge("shop", Shop);
    //forest.AddObject();
    
    Farm.AddEdge("hub", Hub);

    Recycle.AddEdge("hub", Hub);
    Recycle.AddEdge("shop", Shop);
    
    Shop.AddEdge("core", Core);
    Shop.AddEdge("station", Recycle);
    
    this.Haven = Haven;
    
  }
  
  public Space GetEntry () {
    return Haven;
  }


  public void UnlockRoom(string roomName)
  {
    switch (roomName)
    {
      case "room1":
        Room1.HasAccess = true;
        break;
      case "room2":
        Room2.HasAccess = true;
        break;
      default:
        return;
    }
    Util.TypeEffect("Unlocked: " + roomName);

  }

}
