using System;

namespace Pokemonbonus
{
    public class Animal
    {
        private string _name;
        
        public Animal(string name)
        {
            _name = name;
        }
        
        public void WhoAmI()
        {
            Console.WriteLine("i am an animal  !");
        }

        public void Describe()
        {
            Console.WriteLine("My name is {0}.", _name);
        }

        public void Rename(string newName)
        {
            _name = newName;
        }

        public string Name
        {
            get {return _name;}
        }
    }
}