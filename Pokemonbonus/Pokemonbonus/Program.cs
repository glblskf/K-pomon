using System;
using System.Runtime.Remoting.Messaging;

namespace Pokemonbonus
{
  internal class Program
  {
    public static void Main(string[] args)
    {
        Index index = new Index();
        Pokemon starter = Index.GetPokemon(0);
        Console.WriteLine(starter.Name);

    }
  }
}