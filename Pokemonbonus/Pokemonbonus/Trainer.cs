using System;
using System.Collections.Generic;

namespace Pokemonbonus
{
    public class Trainer : Animal
    {
        private static string _name;
        private static int _age;
        private static List<Pokemon> _pokemons = new List<Pokemon>();
        private static int _selected = 0;

        public Trainer(string name, int age)
            : base(name)
        {
            _name = name;
            _age = age;
        }

        public static void WhoAmI()
        {
            Console.WriteLine("i am an Trainer !");
        }

        public static void Describe()
        {
            Console.WriteLine();
            Console.WriteLine("My name is {0}, I'm {1} and have {2} Pokemon !", _name, _age, NumberOfPokemon());
        }

        public static int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public static void Birthday()
        {
            _age++;
        }

        public static int NumberOfPokemon()
        {
            return _pokemons.Count;
        }

        public static void CatchAPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }

        public static void MyPokemon()
        {
            int i = 0;
            Console.WriteLine();
            Console.WriteLine("      My pokemon are :");
            while (i < _pokemons.Count)
            {
                Console.WriteLine("- {0}", _pokemons[i]);
                i++;
            }
        }

        public bool IsAlive()
        {
            foreach (Pokemon pokemon in _pokemons)
            {
                if (pokemon.IsKO) return false;
            }
            return true;
        }

        public void Select()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Choose a pokemon");
                foreach (var pokemon in _pokemons)
                {
                    Console.Write(" - {0}", pokemon.Name); 
                    pokemon.Describe();
                }
                _selected = int.Parse(Console.ReadLine());
            } while (_selected < 0 || _selected >= _pokemons.Count);
        }

        public Pokemon GetSelectedPokemon()
        {
            return _pokemons[_selected];
        }
    }
}