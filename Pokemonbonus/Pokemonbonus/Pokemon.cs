using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Pokemonbonus
{

    public class Pokemon : Animal
    {

        private List<Attack.Poketype> _type;
        private string _name;
        
        private int _level;
        private int _xp = 0;
        private int _xpCap = 10;
        
        private bool _isKO = false;
        
        private int _maxLife;
        private int _life;
        private int _force;
        private int _defence;
        private int _vitesse;
        private int _special;
        
        private List<Attack> _attacks;

        public Pokemon(string name, Dictionary<string, int> stat, List<Attack.Poketype> type, List<Attack> attacks)
            : base(name)
        {
            _name = name;
            _maxLife = stat["HP"];
            _life = stat["HP"];
            _force = stat["FORCE"];
            _defence = stat["DEFENSE"];
            _vitesse = stat["VITESSE"];
            _special = stat["SPECIAL"];
            _type = type;
            _attacks = attacks;
            _level = 1;
        }

        public void WhoAmI()
        {
            Console.WriteLine("      i am an pokemon !");
        }

        public void Describe()
        {
            Console.WriteLine();
            Console.WriteLine("      My name is {0} I'm a pokemon of type {1} and I'm level {2}", _name, _type, _level);
        }

        public string Name => _name;
        

        public void levelUp(int amount)
        {
            _xp += amount;
            while (_xp > _xpCap)
            {
                _level++;
                _xp -= _xpCap;
                _xpCap += _xpCap/10;
            }
        }

        public void GetHurt(int damage)
        {
            _life -= damage;
        }

        public bool IsKO
        {
            get { return _isKO; }
            set { _isKO = value; }
        }

        public void Heal(int life)
        {
            _life = life;
            if (_life > _maxLife)
            {
                _life = _maxLife;
            }
        }

        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }

        public int Level
        {
            get { return _level; }
        }

        public int Force
        {
            get { return _force; }
        }

        public int Defence
        {
            get { return _defence; }
        }

        public List<Attack.Poketype> Type
        {
            get { return _type; }
        }
    }
}