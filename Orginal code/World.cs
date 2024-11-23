/* Worldclass for modeling the entire in-game world
 */

class World {
  public Space Haven { get; }
  
  public World () {
    Space Haven        = new Space("haven");
    Space Nexus        = new Space("nexus");
    Space Hub          = new Space("hub");
    Space Core         = new Space("core");
    Space Farm         = new Space("farm");
    Space Recycle      = new Space("station") { HasDrop = true} ;
    Space Shop         = new Space("shop") { HasShop = true };
    
    Haven.AddEdge("nexus", Nexus);

    Nexus.AddEdge("hub", Hub);
    //path.AddObject();
    
    Hub.AddEdge("core", Core);
    Hub.AddEdge("playground", Farm);
    Hub.AddEdge("station", Recycle);

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


}
