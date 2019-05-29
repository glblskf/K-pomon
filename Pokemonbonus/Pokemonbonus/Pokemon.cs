using System;

namespace Pokemonbonus
{

    public class Pokemon : Animal
    {
        public enum Poketype
        {
            POISON,
            FIRE,
            WATER,
            GRASS,
            ELECTRIK
        }

        private Poketype type;
        private string name;
        private int damage;
        private int level;
        private bool isKo;
        private int life;

        public Pokemon(string name, int life, int damage, Poketype type)
            : base(name)
        {
            this.name = name;
            this.life = life;
            this.type = type;
            this.level = 1;
            this.isKo = false;
            this.damage = damage;
        }

        public void WhoAmI()
        {
            Console.WriteLine("i am an pokemon !");
        }

        public void Describe()
        {
            Console.WriteLine("My name is {0} I'm a pokemon of type {1} and I'm level {2}", name, type, level);
        }

        public void levelUp()
        {
            this.level += level;
        }

        public void GetHurt(int damage)
        {
            this.life -= damage;
        }

        public bool isKO
        {
            get { return isKO; }
            set { isKO = value; }
        }

        public void Heal(int life)
        {
            this.life = life;
        }

        public int Life
        {
            get { return life; }
            set { life = value; }
        }

        public int Attack()
        {
            Console.WriteLine("{0} uses cut, it's super effective", name);
            return this.damage;
        }
    }

}