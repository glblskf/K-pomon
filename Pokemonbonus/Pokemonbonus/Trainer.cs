using System;
using System.Collections.Generic;

namespace Pokemonbonus
{
    public class Trainer : Animal
    {
        private string _name;
        private int _age;
        private List<Pokemon> _pokemons = new List<Pokemon>();
        private int _selected = 0;

        public Trainer(string name, int age)
            : base(name)
        {
            _name = name;
            _age = age;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        
        public void WhoAmI()
        {
            Console.WriteLine("      i am an Trainer !");
        }

        public void Describe(){
            Console.WriteLine("      My name is {0}, I'm {1} and have {2} Pokemon !", _name, _age, NumberOfPokemon());
        }

        public void Birthday()
        {
            _age++;
        }

        public int NumberOfPokemon()
        {
            Console.WriteLine();

            return _pokemons.Count;
        }

        public void CatchAPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }

        public void MyPokemon()
        {
            int i = 0;
            Console.WriteLine();
            Console.WriteLine("      My pokemon are :");
            Console.WriteLine();
            while (i < _pokemons.Count)
            {
                Console.WriteLine("> {0}",_name);
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
                    Console.Write(" - ");
                    pokemon.GetPokemonCombatInfo();
                }
                _selected = int.Parse(Console.ReadLine());
            } while (_selected < 0 || _selected >= _pokemons.Count);
            Console.WriteLine("{0}, Go !", GetSelectedPokemon().Name);
            Console.ReadLine();
        }

        public Pokemon GetSelectedPokemon()
        {
            return _pokemons[_selected];
        }
    }
}