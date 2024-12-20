namespace temp;

public class Map
{
    //@ holder formatering på print
    public static string DefaultMap = @"
               +---------+
               |  Haven  |
               +---------+
                    |
               +---------+
               |  Nexus  |
               +---------+
                    |
               +---------+
               |   Hub   |
      +--------+---------+--------+
      |                  |         |
+---------+        +---------+ +---------+
|   Core  |        |  Farm   | | Station |
+---------+        +---------+ +---------+
      |                            |
+---------+                        |
|   Shop  |------------------------+
+---------+
";
    public static string Room1UnlockedMap = @"
               +---------+
               |  Haven  |
               +---------+
                    |
               +---------+
               |  Nexus  |
               +---------+
                    |
               +---------+
               |   Hub   |
      +--------+---------+------------------------------+
      |                  |         |                    |
+---------+        +---------+ +---------+          +---------+
|   Core  |        |  Farm   | | Station |          | Vault   |
+---------+        +---------+ +---------+          +---------+
      |                            |
+---------+                        |
|   Shop  |------------------------+
+---------+
";
    public static string Room2UnlockedMap = @"
               +---------+
               |  Haven  |
               +---------+
                    |
               +---------+
               |  Nexus  |
               +---------+
                    |
               +---------+
               |   Hub   |
      +--------+---------+----------+
      |                  |         |                    
+---------+        +---------+ +---------+          +---------+
|   Core  |        |  Farm   | | Station | -------- | Sanctum |
+---------+        +---------+ +---------+          +---------+
      |                            |
+---------+                        |
|   Shop  |------------------------+
+---------+
";
    public static string BothRoomsUnlockedMap = @"
               +---------+
               |  Haven  |
               +---------+
                    |
               +---------+
               |  Nexus  |
               +---------+
                    |
               +---------+                         +---------+
               |   Hub   |                         |  Vault  |
      +--------+---------+----------+--------------+---------+                
      |                  |         |                    |
+---------+        +---------+ +---------+          +---------+
|   Core  |        |  Farm   | | Station | -------- | Sanctum |
+---------+        +---------+ +---------+          +---------+
      |                            |
+---------+                        |
|   Shop  |------------------------+
+---------+
";
}
