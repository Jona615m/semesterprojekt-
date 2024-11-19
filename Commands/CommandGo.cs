/*
/* Command for transitioning between spaces
 #1#

class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "To choose a path type go ...";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
    if (GuardEq(parameters, 1)) {
      Console.WriteLine("You are going the wrong path!");
      return;
    }
    //Guard tjekker at den tjekker der kun er et rum at hoppe ind i.
    //Eks. "go north" virker, men "go north south" virker ikke, da kommandoen kun tager et rum.

    context.Transition(parameters[0]);
  }
}
*/
