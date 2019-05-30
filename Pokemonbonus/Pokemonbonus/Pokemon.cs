using System;
using System.Collections.Generic;

namespace Pokemonbonus
{

    public class Pokemon : Animal
    {
        
        private Attack.Poketype _type;
        private string _name;
        private int _damage;
        private int _level;
        private bool _isKO;
        private int _maxLife;
        private int _life;

        public Pokemon(string name, int life, int damage, Attack.Poketype type)
            : base(name)
        {
            _name = name;
            _maxLife = life;
            _life = life;
            _type = type;
            _level = 1;
            _isKO = false;
            _damage = damage;
        }

        public void WhoAmI()
        {
            Console.WriteLine("i am an pokemon !");
        }

        public void Describe()
        {
            Console.WriteLine("My name is {0} I'm a pokemon of type {1} and I'm level {2}", _name, _type, _level);
        }

        public void levelUp()
        {
            _level++;
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
        }

        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }

        public int Attack()
        {
            Console.WriteLine("{0} uses cut, it's super effective", _name);
            return _damage;
        }
    }

}