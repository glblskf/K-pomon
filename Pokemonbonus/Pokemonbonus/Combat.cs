

using System;

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

        public bool PlayerTurn(Trainer player)
        {
            Console.WriteLine("======   TOUR DE {0}   =======", player);
        }
    }
}