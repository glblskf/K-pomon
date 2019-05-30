using System;

namespace Pokemonbonus
{
    public class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine(@"""                                  ,'\
                                _.----.        ____         ,'  _\   ___    ___     ____
                            _,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
                            \      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
                            \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
                            \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
                            \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
                            \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
                            \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
                             \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
                              \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                                     `'                             '-._|
    
                                                                              is_not_a_copied_game tm""");
            Console.ReadLine();
        }
        
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
            Console.WriteLine();
            Console.WriteLine(               "                 ****************************************************************");
            Console.WriteLine(               "                 *                  What do you want to do ?                    *");
            Console.WriteLine(               "                 *                                                              *");
            Console.WriteLine(               "                 *         | fight: 1 | Shop 2 | my stats: 3 | option: 4 |      *");
            Console.WriteLine(               "                 *                                                              *");
            Console.WriteLine(               "                 ****************************************************************");
            
            Console.Write(                   "      > ");

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
            Console.WriteLine();
            Console.WriteLine(               "                 ****************************************************************");
            Console.WriteLine(               "                 *                          Menu Option                         *");
            Console.WriteLine(               "                 *                                                              *");
            Console.WriteLine(               "                 *      |Quit: 1 | Pause : 2 | restart : 3| HomePage : 10|      *");
            Console.WriteLine(               "                 *                                                              *");
            Console.WriteLine(               "                 ****************************************************************");
            
            Console.Write(                   "      > ");
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
            Console.WriteLine();
            Console.WriteLine(               "                 ****************************************************************");
            Console.WriteLine(               "                 *                           Statistics                         *");
            Console.WriteLine(               "                 *                                                              *");
            Console.WriteLine(               "                 *           | MyID : 1 | MyPokemon : 2 | Homepage : 10 |       *");
            Console.WriteLine(               "                 *                                                              *");
            Console.WriteLine(               "                 ****************************************************************");

            Console.Write(                   "      > ");
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
            Console.WriteLine();
            Console.WriteLine(               "                 ****************************************************************");
            Console.WriteLine(               "                 *                             *SHOP*                           *");
            Console.WriteLine(               "                 *                                                              *");
            Console.WriteLine(               "                 *             | buy Pokeball : 1 | Homepage : 10 |             *");
            Console.WriteLine(               "                 *                                                              *");
            Console.WriteLine(               "                 ****************************************************************");
            
            Console.Write(                   "      > ");
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