

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

        public void CombatLoop()
        {
            while (_player1.IsAlive() && _player2.IsAlive())
            {
                PlayerTurn(_player1);
                PlayerTurn(_player2);
                Console.ReadLine();
            }
        }

        public void PlayerTurn(Trainer player)
        {
            List<string> actions = new List<string>(){"Attaquer", "Sac", "Fuir", "Changer de pokemon"};
                Console.WriteLine("=======|  TOUR DE {0}  |=======", player.Name);
            Console.WriteLine("Choisissez une action :");
            for (int i = 0; i < actions.Count; i++)
            {
                Console.WriteLine("  {0}- {1}", i+1, actions);
            }

            int choice;
            do
            {
                Console.Write(">> ");
                choice = int.Parse(Console.ReadLine()) - 1;
            } while (choice >= 0 && choice < actions.Count);
            
        }
    }
}