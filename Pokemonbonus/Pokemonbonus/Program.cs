using System;
using System.Runtime.Remoting.Messaging;

namespace Pokemonbonus
{
  internal class Program
  {
    public static void Main(string[] args)
    {   
      Attack surf = new Attack("Surf", "", Attack.Poketype.EAU);
      
      Console.WriteLine(surf.GetMultiplier(Attack.Poketype.FEU));
    }  
  }
}