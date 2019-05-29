using System;

namespace Pokemonbonus
{
    public class Menu
    {
        public enum Action
        {
            FIGHT,
            SHOP,
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

        public enum Shop
        {
            SHOP,
            HOMEPAGE
        }
    
        public static Action GetNextAction()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("| fight: 1 | Shop 2 | my stats: 3 | option: 4 |");

            string read1 = Console.ReadLine();
            switch (read1)
            {
                case "1":
                    return Action.FIGHT;
                case "2":
                    return Action.SHOP;
                case "3":
                    return Action.SHOW;
                case "4":
                    return Action.OPTION;
                default:
                    return GetNextAction();
            }
        }

        public static Option GetOption()
        {
            Console.Clear();
            Console.WriteLine("|Quit: 1 | Pause : 2 | restart : 3| HomePage : 10|");
            string read2 = Console.ReadLine();
            switch (read2)
            {
                case "1":
                    return Option.QUIT;
                case "2":
                    return Option.PAUSE;
                case "3":
                    return Option.RESTART;
                case "10":
                    return Option.HOMEPAGE;
                default:
                    return GetOption();
            }
        }

        public static Stat GetStat()
        {
            Console.Clear();
            Console.WriteLine("|MyID : 1 | MyPokemon : 2 | Homepage : 10|");
            string read3 = Console.ReadLine();
            switch (read3)
            {
                case "1":
                    return Stat.MYID;
                case "2":
                    return Stat.MYPOKEMON;
                case "10":
                    return Stat.HOMEPAGE;
                default:
                    return GetStat();
            }
        }

        public static Shop Getshop()
        {
            Console.Clear();
            Console.WriteLine("|buy pokeball : 1 | Homepage : 10 | ");
            string read4 = Console.ReadLine();
            switch (read4)
            {
                    case "1":
                        return Shop.SHOP;
                    case "10":
                        return Shop.HOMEPAGE;
                    default:
                        return Getshop();
            }
        }
    }
}