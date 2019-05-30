using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Media;

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
                         
                         
                         break;

                     case Menu.Action.SHOP:
                         Menu.Shop myshop = Menu.Getshop();
                         switch (myshop)
                         {
                                 case Menu.Shop.SHOP:

                                     break;
                                 case Menu.Shop.HOMEPAGE:
                                     Menu.Getshop();
                                     break;
                         }
                         break;
                     
                     case  Menu.Action.SHOW:

                         Menu.Stat mystat = Menu.GetStat();
                         switch (mystat)
                         {
                                 case Menu.Stat.MYPOKEMON:
                                     
                                     break;
                                 case Menu.Stat.MYID:
                                     
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

                                      break;
                                  case Menu.Option.RESTART:

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
        
        
        
        public static void Welcome()
        {
            System.Media.SoundPlayer Music = new SoundPlayer();
            Music.SoundLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\music.wav";
            Music.PlayLooping();
            
            Menu.MainMenu();
        }


        public static Trainer Starter()
        {

            Trainer trainer1 = new Trainer("",0);
                
            Index newindex= Index; 
            
            Console.WriteLine("Enter your name to start or exit:");
            Console.WriteLine("|Enter my name : 1");
            Console.WriteLine("|Exit : 2");

            string readme = Console.ReadLine();

            switch (readme)
            {
                    case "1":
                        Console.Write(">");
                        string name = Console.ReadLine();
                        Console.WriteLine("How old are you ?");
                        Console.Write(">");
                        int age = int.Parse(Console.ReadLine());
                        Trainer _trainer = new Trainer(name, age);
                        trainer1 = _trainer;
                        break;
                    case "2":
                        Console.WriteLine("goodbye my friend !");
                        break;
                    default:
                        Starter();
                        break;
            }

            return trainer1;
        }
      
    }
  
}