namespace temp;

public class Map
{
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
|   Core  |        |  Farm   | | Recycle |          | Room1   |
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
|   Core  |        |  Farm   | | Recycle | -------- | Room2  |
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
               |   Hub   |                         |  Room1  |
      +--------+---------+----------+--------------+---------+                
      |                  |         |                    |
+---------+        +---------+ +---------+          +---------+
|   Core  |        |  Farm   | | Recycle | -------- | Room2  |
+---------+        +---------+ +---------+          +---------+
      |                            |
+---------+                        |
|   Shop  |------------------------+
+---------+
";
}
