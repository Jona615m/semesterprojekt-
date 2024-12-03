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
|   Core  |        |  Farm   | | Recycle |
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
|   Core  |        |  Farm   | | Recycle |          | Vault   |
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
|   Core  |        |  Farm   | | Recycle | -------- | Sanctum |
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
|   Core  |        |  Farm   | | Recycle | -------- | Sanctum |
+---------+        +---------+ +---------+          +---------+
      |                            |
+---------+                        |
|   Shop  |------------------------+
+---------+
";
}
