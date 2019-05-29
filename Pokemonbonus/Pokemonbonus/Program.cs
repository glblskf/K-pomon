using System;

namespace Pokemonbonus
{
  internal class Program
  {
    public static void Main(string[] args)
    {   
      Trainer red = new Trainer("Red", 10);
      Pokemon pichu = new Pokemon("pichu", 10, 1, Pokemon.Poketype.ELECTRIK);
      
      MyGame.Updates();
    }
  }
}