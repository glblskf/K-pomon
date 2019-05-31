using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Pokemonbonus
{
    public class MyGame
    {
        public static void Updates()
        {
            bool end = false;

            while (!end)
            {
                Menu.Action nextact = Menu.GetNextAction();

                switch (nextact)
                {
                    case Menu.Action.FIGHT:
                        //debut combat
                        combatmusic();
                        Combat combat = new Combat(new Trainer(trainername, 10), new Trainer(rivalname, 10), true);
                        combat.CombatLoop();

                        //fin combat et retour au menu
                        music();
                        break;

                    case Menu.Action.SHOP:
                        storemusic();
                        Menu.Shop myshop = Menu.Getshop();

                        switch (myshop)
                        {
                            case Menu.Shop.SHOP:
                                Console.ReadLine();
                                music();
                                break;
                            case Menu.Shop.POKECENTER:
                                Console.ReadLine();
                                music();
                                break;
                            case Menu.Shop.HOMEPAGE:
                                music();
                                Menu.GetNextAction();
                                break;
                        }

                        break;

                    case Menu.Action.SHOW:

                        Menu.Stat mystat = Menu.GetStat();
                        switch (mystat)
                        {
                            case Menu.Stat.MYPOKEMON:
                                Trainer.MyPokemon();
                                Console.ReadLine();
                                Menu.GetStat();
                                break;
                            case Menu.Stat.MYID:
                                Trainer.WhoAmI();
                                Trainer.Describe();
                                Console.ReadLine();
                                Menu.GetStat();
                                
                                break;
                            case Menu.Stat.HOMEPAGE:
                                Menu.GetNextAction();
                                break;
                            default:
                                Menu.GetStat();
                                break;
                        }

                        break;

                    case Menu.Action.OPTION:
                        Menu.Option nextoption = Menu.GetOption();
                        switch (nextoption)
                        {
                            case Menu.Option.QUIT:
                                end = true;
                                Console.WriteLine("goodbye my friend");
                                break;
                            case Menu.Option.PAUSE:
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine(               "                 ****************************************************************");
                                Console.WriteLine(               "                 *                                                              *");
                                Console.WriteLine(               "                 *                         *GAME PAUSED*                        *");
                                Console.WriteLine(               "                 *                                                              *");
                                Console.WriteLine(               "                 *                                                              *");
                                Console.WriteLine(               "                 ****************************************************************");
                                Console.WriteLine();
                                Console.WriteLine("                                                  <-/");
                                Console.ReadLine();                                
                               
                                break;
                            case Menu.Option.RESTART:
                                Console.Clear();
                                Welcome();
                                Getmyfirstpokemon();
                                break;
                            case Menu.Option.HOMEPAGE:
                                Menu.GetNextAction();
                                break;
                            default:
                                Menu.GetOption();
                                break;
                        }

                        break;

                    default:
                        Menu.GetNextAction();
                        break;
                }
            }
        }

        
        public static void storemusic()
        {
            System.Media.SoundPlayer Music = new SoundPlayer();
            Music.SoundLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\store.wav";
            Music.PlayLooping();
        }

        public static void music()
        {

            System.Media.SoundPlayer Music = new SoundPlayer();
            Music.SoundLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\music.wav";
            Music.PlayLooping();

        }

        public static void combatmusic()
        {

            System.Media.SoundPlayer Music = new SoundPlayer();
            Music.SoundLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\combat.wav";
            Music.PlayLooping();
        }

        public static void Welcome()
        {
            music();
            Menu.MainMenu();
        }

        public static string trainername;
        public static string rivalname;
        
        public static Trainer Starter()
        {

            Trainer trainer1 = new Trainer("", 0);

            Index index = new Index();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                     *Enter your name to start or exit*              ");
            Console.WriteLine();
            Console.WriteLine("            | Enter my name : 1");
            Console.WriteLine("            | Exit : 2");
            Console.WriteLine();
            Console.Write("            > ");
            string readme = Console.ReadLine();

            switch (readme)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("      Oak: wath's your name again ? !");
                    Console.WriteLine();
                    Console.Write("      > ");
                    string name = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("      Oak: Nice to meet you {0} !, How old are you ?", name);
                    Console.WriteLine();
                    Console.Write("      > ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Trainer _trainer = new Trainer(name, age);
                    trainername = name;
                    trainer1 = _trainer;
                    break;
                case "2":
                    Console.WriteLine("GAME: goodbye my friend !");
                    break;
                default:
                    Starter();
                    break;
            }

            return trainer1;
        }

        public static void myfirstpokemon()
        {

            Console.WriteLine("         *| Bulbizaur : 1 | Charmander : 2 | Squirtle : 3 |*");
            Console.WriteLine();
            Console.Write("      > ");
            string myread = Console.ReadLine();

            switch (myread)
            {
                case "1":
                    Trainer.CatchAPokemon(Index.GetPokemon(0));
                    break;
                case "2":
                    Trainer.CatchAPokemon(Index.GetPokemon(3));
                    break;
                case "3":
                    Trainer.CatchAPokemon(Index.GetPokemon(6));
                    break;
                default:
                    myfirstpokemon();
                    break;
            }
        }



        public static void Getmyfirstpokemon()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("      Professor Oak :-Hello there! Welcome to the world of pokémon! My name is Oak!");
            Console.WriteLine();
            Console.WriteLine("                                                  <-/");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("      Oak: -People call me the pokémon Prof! This world is inhabited by creatures called pokémon! ");
            Console.WriteLine();
            Console.WriteLine("                                                  <-/");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("      Oak: -For some people, pokémon are pets. Others use them for fights. ");
            Console.WriteLine();
            Console.WriteLine("                                                  <-/");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("      Oak: -Myself...I study pokémon as a profession.");
            Console.WriteLine();
            Console.WriteLine("                                                  <-/");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("      Oak: -But first, tell me about yourself.");
            Console.WriteLine();
            Console.WriteLine("                                                  <-/");
            Console.ReadLine();
            Console.Clear();

            Starter();

            Console.WriteLine();
            Console.WriteLine(@"""                                   _\|/^
                                   (_oo /
                                  /-|--/
                                  \ |
                                    /--i
                                   /   L
                                   L""");            
            Console.WriteLine();
            Console.WriteLine("      Oak: -This is my grandson, he's been your rival since you both were babies.");
            Console.WriteLine();
            Console.WriteLine("                                                  <-/");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("      Oak: -....Erm, what was his name now ?");
            Console.WriteLine();
            Console.Write("      > ");
            string rival = Console.ReadLine();
            rivalname = rival;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("      Oak: -That's right! I remember now !, his name is {0}!", rival);
            Console.WriteLine("      Oak: -{0}!", trainername);
            Console.WriteLine("      Oak: -Your very own PoKeMoN legend is about to unfold!");
            Console.WriteLine();
            Console.WriteLine("                                                  <-/");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("      Oak: -A world of dreams and adventures with PoKeMoN awaits! Let's go !");
            Console.WriteLine("      Oak: -It's now time to choose your first PoKeMoN !");
            Console.WriteLine();

            myfirstpokemon();
            Updates();
        }
    }
}