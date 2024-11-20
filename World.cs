/* Worldclass for modeling the entire in-game world
 */

class World {
  public Space gate { get; }
  
  public World () {
    Space gate       = new Space("gate");
    Space path        = new Space("path");
    Space picnic      = new Space("picnic");
    Space forest      = new Space("forest");
    Space playground  = new Space("playground");
    Space recycle     = new Space("recycle");
    Space Shop = new Space("shop") { HasShop = true };
    
    gate.AddEdge("path", path);

    path.AddEdge("picnic", picnic);
    //path.AddObject();
    
    picnic.AddEdge("forest", forest);
    picnic.AddEdge("playground", playground);
    picnic.AddEdge("recycle", recycle);

    forest.AddEdge("picnic", picnic);
    forest.AddEdge("shop", Shop);
    //forest.AddObject();
    
    playground.AddEdge("picnic", picnic);

    recycle.AddEdge("picnic", picnic);
    recycle.AddEdge("shop", Shop);
    
    Shop.AddEdge("forest", forest);
    Shop.AddEdge("recycle", recycle);
    
    this.gate = gate;
    
  }
  
  public Space GetEntry () {
    return gate;
  }


}
