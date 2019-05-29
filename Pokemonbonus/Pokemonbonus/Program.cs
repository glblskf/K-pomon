using System;

namespace Pokemonbonus
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      
      
      
    }

    public enum Action
    {
        FIGHT,
        CAPTURE,
        TRAIN,
        SHOW,
        OPTION
    }
    
    public enum Option
    {
        QUIT,
        PAUSE,
        RESTART,
        HOMEPAGE
    }

    public enum Stat
    {
       MYPOKEMON,
       MYID,
       HOMEPAGE,
    }
    
    
    public static Action GetNextAction()
    {
      Console.Clear();
      Console.WriteLine("What do you want to do ?");
      Console.WriteLine("| fight: 1 | Capture: 2 | Train: 3 |");
      Console.WriteLine("| My stats: 4 |");
      Console.WriteLine("| Option: 10 |");
      string read1 = Console.ReadLine();
      switch (read1)
      {
        case "1":
          return Action.FIGHT;
        case "2":
          return Action.CAPTURE;
        case "3":
          return Action.TRAIN;
        case "4":
          return Action.SHOW;
        case "10":
          return Action.OPTION;
        default:
          return GetNextAction();
      }
    }

    public static Option GetOption()
    {
      Console.Clear();
      Console.WriteLine("|Quit: 1 | Pause : 2 | restart : 3| HomePage : 4|");
      string read2 = Console.ReadLine();
      switch (read2)
      {
        case "1":
          return Option.QUIT;
        case "2":
          return Option.PAUSE;
        case "3":
          return Option.RESTART;
        case "4":
          return Option.HOMEPAGE;
        default:
          return GetOption();
      }
    }

    public static Stat GetStat()
    {
      Console.Clear();
      Console.WriteLine("|MyID : 1 | MyPokemon : 2 | Homepage : 3|");
      string read3 = Console.ReadLine();
      switch (read3)
      {
         case "1":
           return Stat.MYID;
         case "2":
           return Stat.MYPOKEMON;
         case "3":
           return Stat.HOMEPAGE;
         default:
           return GetStat();
      }
    }
    
    
    
    public void Update()
    {
      while ()
      {
        
      }
    }
    
    
  }
}