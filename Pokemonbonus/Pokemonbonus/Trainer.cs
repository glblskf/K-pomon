using System;
using System.Collections.Generic;

namespace Pokemonbonus
{
    public class Trainer : Animal
    {
        private string name;
        private int age;
        private List<Pokemon> mypokemon = new List<Pokemon>();

        public Trainer(string name, int age)
            : base(name)
        {
            this.name = name;
            this.age = age;
        }

        public void WhoAmI()
        {
            Console.WriteLine("i am an Trainer !");
        }

        public void Describe()
        {
            Console.WriteLine("My name is {0}, I'm {1} and have {2} Pokemon !", name, age, mypokemon.Count);
        }

        public bool Age
        {
            get { return Age; }
            set { Age = value; }
        }

        public void Birthday()
        {
            this.age += age;
        }

        public int NumberOfPokemon()
        {
            return mypokemon.Count;
        }

        public void CatchAPokemon(Pokemon pokemon)
        {
            mypokemon.Add(pokemon);
        }

        public void MyPokemon()
        {
            int i = 0;
            Console.WriteLine("My pokemon are :");
            while (i < mypokemon.Count)
            {
                Console.WriteLine("- {0}", mypokemon[i]);
                i++;
            }
        }

        public bool IsAlive()
        {
            foreach (Pokemon pokemon in mypokemon)
            {
                if (pokemon.IsKO) return false;
            }
            return true;
        }
    }
}
