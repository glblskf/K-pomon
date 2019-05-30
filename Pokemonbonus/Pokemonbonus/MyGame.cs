using System;
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
            Music.SoundLocation = Directory.GetCurrentDirectory() + @"\music.MP3";
            Music.PlayLooping();
        }
    }
    
    
    
    
}