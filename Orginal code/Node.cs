/* Node class for modeling graphs
 */

class Node {
  protected string name;
  protected Dictionary<string, Node> edges = new Dictionary<string, Node>();
  private List<GameObject> objects = new List<GameObject>(); // List to hold objects in the room
  
  public Node (string name) {
    this.name = name;
  }

  public String GetName () {
    return name;
  }
  
  public void AddEdge (string name, Node node) {
    edges.Add(name, node);
  }
  
  public virtual Node FollowEdge (string direction) {
    try
    {
        return edges[direction]; // Forsøger at "catche direction", hvis den ikke kan udskriver den exceptionen "KeyNotFoundException"

    }
    catch (KeyNotFoundException)
    {
        return null;
        //når den returner null, så referer den tilbage til context linje 20
    }
    
  }
 
}

