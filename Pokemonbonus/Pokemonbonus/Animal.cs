using System;

namespace Pokemonbonus
{
    public class Animal
    {
        private string name;
        
        public Animal(string name)
        {
            this.name = name;
        }
        
        public void WhoAmI()
        {
            Console.WriteLine("i am an animal  !");
        }

        public void Describe()
        {
            Console.WriteLine("My name is {0}.",name);
        }

        public void Rename(string newName)
        {
            this.name = newName;
        }

        public string Name
        {
            get {return name;}
        }
    }
}