

using System;
using System.Collections.Generic;
using System.IO;

namespace Pokemonbonus
{
    public class Combat
    {
        private Trainer _player1;
        private Trainer _player2;
        private bool _isWild;
        
        public Combat(Trainer player1, Trainer player2, bool isWild)
        {
            _player1 = player1;
            _player2 = player2;
            _isWild = isWild;
        }

        public  void CombatLoop()
        {
            while (_player1.IsAlive() && _player2.IsAlive())
            {
                PlayerTurn(_player1, _player2);
                CheckAlive();
                PlayerTurn(_player2, _player1);
                CheckAlive();
            }
        }

        public void CheckAlive()
        {
            if (_player1.GetSelectedPokemon().IsKO)
            {
                Console.Clear();
                Console.WriteLine("{0} needs to swap pokemon", _player1);
                _player1.Select();
                Console.Clear();
                Console.WriteLine("{0} : Do you want to swap pokemon ? {Yes}/{No}", _player2);
                if (Console.ReadLine() == "Yes") _player2.Select();
            }
            else if (_player1.GetSelectedPokemon().IsKO)
            {
                Console.Clear();
                Console.WriteLine("{0} needs to swap pokemon", _player1);
                _player1.Select();
                Console.Clear();
                Console.WriteLine("{0} : Do you want to swap pokemon ? {Yes}/{No}", _player2);
                if (Console.ReadLine() == "Yes") _player2.Select();
            }
        }

        public void PlayerTurn(Trainer player, Trainer opponent)
        {
            Console.Clear();
            List<string> actions = new List<string>(){"Attaquer", "Sac", "Fuir", "Changer de pokemon"};
            Console.WriteLine("      =======|  TOUR DE {0}  |=======", player.Name);
            
            Console.Write("{0}'s pokemon", player.Name);
            player.GetSelectedPokemon().GetPokemonCombatInfo();
            
            Console.Write("{0}'s pokemon", opponent.Name); 
            opponent.GetSelectedPokemon().GetPokemonCombatInfo();

            Console.WriteLine("Choisissez une action :");
            for (int i = 0; i < actions.Count; i++)
            {
                Console.WriteLine("  {0}- {1}", i+1, actions[i]);
            }

            int choice;
            do
            {
                Console.Write(">> ");
                choice = int.Parse(Console.ReadLine()) - 1;
            } while (!(choice >= 0 && choice < actions.Count));
            Console.WriteLine(choice);

            switch (choice)
            {
                case 0:
                    Attack(player, opponent);
                    break;
                case 1:
                    Bag();
                    break;
                case 2:
                    Flee();
                    break;
                case 3:
                    ChangePokemon(player);
                    break;
                default:
                    throw new Exception();
            }
        }

        public void Attack(Trainer player, Trainer opponent)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("      ======|   ATTACK   |======");
            foreach (var attack in player.GetSelectedPokemon().Attacks)
            {
                attack.Describe();
            }
            Console.Write(">> ");
            string selected = Console.ReadLine();
            player.GetSelectedPokemon().Attack(int.Parse(selected) - 1, opponent.GetSelectedPokemon());
        }

        public void Bag()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("      =======|   BAG   |=======");
            
        }

        public void Flee()
        {
            Console.Clear();
            Console.WriteLine();
            
            Console.WriteLine("      =======|   FLEE   |=======");
            Console.WriteLine("you ran over from your opponent !");
        }

        public void ChangePokemon(Trainer player)
        {
            player.Select();
        }
    }
}