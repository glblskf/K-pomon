using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Pokemonbonus
{
    public class Index
    {
        private string HP = "HP";
        private string ATK = "FORCE";
        private string DEF = "DEFENSE";
        private string VIT = "VITESSE";
        private string SPE = "SPECIAL";
        private string T1 = "TYPE1";
        private string T2 = "TYPE2";
        private static List<Dictionary<string, int>> pokeStat;
        private static List<string> pokeName;
        private static List<Attack> pokeAttack;
        public Index()
        {
            pokeStat = new List<Dictionary<string, int>>();   
            pokeStat.Add(new Dictionary<string, int>(){{HP, 45}, {ATK, 49}, {DEF, 49}, {VIT, 45}, {SPE, 65}, {T1, 3}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 45}, {ATK, 62}, {DEF, 63}, {VIT, 60}, {SPE, 80}, {T1, 3}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 83}, {DEF, 83}, {VIT, 80}, {SPE, 100}, {T1, 3}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 39}, {ATK, 52}, {DEF, 43}, {VIT, 65}, {SPE, 50}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 58}, {ATK, 64}, {DEF, 58}, {VIT, 85}, {SPE, 65}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 78}, {ATK, 84}, {DEF, 78}, {VIT, 100}, {SPE, 85}, {T1, 1}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 44}, {ATK, 48}, {DEF, 65}, {VIT, 43}, {SPE, 50}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 59}, {ATK, 63}, {DEF, 80}, {VIT, 58}, {SPE, 65}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 78}, {ATK, 83}, {DEF, 100}, {VIT, 78}, {SPE, 85}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 45}, {ATK, 30}, {DEF, 35}, {VIT, 45}, {SPE, 20}, {T1, 12}, {T2, 12}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 20}, {DEF, 55}, {VIT, 20}, {SPE, 25}, {T1, 12}, {T2, 12}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 45}, {DEF, 50}, {VIT, 70}, {SPE, 80}, {T1, 12}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 35}, {DEF, 30}, {VIT, 50}, {SPE, 20}, {T1, 12}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 45}, {ATK, 25}, {DEF, 50}, {VIT, 35}, {SPE, 25}, {T1, 12}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 80}, {DEF, 40}, {VIT, 75}, {SPE, 45}, {T1, 12}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 45}, {DEF, 40}, {VIT, 56}, {SPE, 35}, {T1, 0}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 63}, {ATK, 60}, {DEF, 55}, {VIT, 71}, {SPE, 50}, {T1, 0}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 83}, {ATK, 80}, {DEF, 75}, {VIT, 91}, {SPE, 70}, {T1, 0}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 30}, {ATK, 56}, {DEF, 35}, {VIT, 72}, {SPE, 25}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 55}, {ATK, 81}, {DEF, 60}, {VIT, 97}, {SPE, 50}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 60}, {DEF, 30}, {VIT, 70}, {SPE, 65}, {T1, 0}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 90}, {DEF, 30}, {VIT, 70}, {SPE, 31}, {T1, 0}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 35}, {ATK, 60}, {DEF, 44}, {VIT, 55}, {SPE, 40}, {T1, 8}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 85}, {DEF, 60}, {VIT, 80}, {SPE, 65}, {T1, 8}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 35}, {ATK, 55}, {DEF, 30}, {VIT, 90}, {SPE, 50}, {T1, 5}, {T2, 5}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 90}, {DEF, 55}, {VIT, 100}, {SPE, 90}, {T1, 5}, {T2, 5}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 75}, {DEF, 85}, {VIT, 40}, {SPE, 30}, {T1, 9}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 75}, {ATK, 100}, {DEF, 110}, {VIT, 65}, {SPE, 55}, {T1, 9}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 55}, {ATK, 47}, {DEF, 52}, {VIT, 41}, {SPE, 40}, {T1, 8}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 70}, {ATK, 62}, {DEF, 67}, {VIT, 56}, {SPE, 55}, {T1, 8}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 90}, {ATK, 82}, {DEF, 87}, {VIT, 76}, {SPE, 75}, {T1, 8}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 46}, {ATK, 57}, {DEF, 40}, {VIT, 50}, {SPE, 40}, {T1, 8}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 61}, {ATK, 72}, {DEF, 57}, {VIT, 65}, {SPE, 55}, {T1, 8}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 81}, {ATK, 92}, {DEF, 77}, {VIT, 85}, {SPE, 75}, {T1, 8}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 70}, {ATK, 45}, {DEF, 48}, {VIT, 35}, {SPE, 60}, {T1, 11}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 95}, {ATK, 70}, {DEF, 73}, {VIT, 60}, {SPE, 85}, {T1, 11}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 38}, {ATK, 41}, {DEF, 40}, {VIT, 65}, {SPE, 65}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 73}, {ATK, 76}, {DEF, 75}, {VIT, 100}, {SPE, 100}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 115}, {ATK, 45}, {DEF, 20}, {VIT, 20}, {SPE, 25}, {T1, 0}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 140}, {ATK, 70}, {DEF, 45}, {VIT, 45}, {SPE, 50}, {T1, 0}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 45}, {DEF, 35}, {VIT, 55}, {SPE, 40}, {T1, 8}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 75}, {ATK, 80}, {DEF, 70}, {VIT, 90}, {SPE, 75}, {T1, 8}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 45}, {ATK, 50}, {DEF, 55}, {VIT, 30}, {SPE, 75}, {T1, 3}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 65}, {DEF, 70}, {VIT, 40}, {SPE, 85}, {T1, 3}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 75}, {ATK, 80}, {DEF, 85}, {VIT, 50}, {SPE, 100}, {T1, 3}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 35}, {ATK, 50}, {DEF, 55}, {VIT, 25}, {SPE, 55}, {T1, 12}, {T2, 3}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 65}, {DEF, 80}, {VIT, 30}, {SPE, 80}, {T1, 12}, {T2, 3}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 80}, {DEF, 50}, {VIT, 45}, {SPE, 40}, {T1, 12}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 70}, {ATK, 70}, {DEF, 60}, {VIT, 90}, {SPE, 90}, {T1, 12}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 10}, {ATK, 95}, {DEF, 25}, {VIT, 95}, {SPE, 45}, {T1, 9}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 35}, {ATK, 55}, {DEF, 50}, {VIT, 120}, {SPE, 70}, {T1, 9}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 65}, {DEF, 35}, {VIT, 90}, {SPE, 40}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 55}, {DEF, 60}, {VIT, 115}, {SPE, 65}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 80}, {DEF, 48}, {VIT, 55}, {SPE, 50}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 45}, {DEF, 78}, {VIT, 85}, {SPE, 80}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 70}, {DEF, 35}, {VIT, 70}, {SPE, 35}, {T1, 7}, {T2, 7}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 52}, {DEF, 60}, {VIT, 95}, {SPE, 60}, {T1, 7}, {T2, 7}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 82}, {DEF, 45}, {VIT, 60}, {SPE, 50}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 80}, {DEF, 80}, {VIT, 95}, {SPE, 80}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 105}, {DEF, 40}, {VIT, 90}, {SPE, 40}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 65}, {DEF, 65}, {VIT, 90}, {SPE, 50}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 55}, {ATK, 70}, {DEF, 95}, {VIT, 70}, {SPE, 70}, {T1, 2}, {T2, 7}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 90}, {ATK, 110}, {DEF, 15}, {VIT, 90}, {SPE, 105}, {T1, 11}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 35}, {DEF, 30}, {VIT, 105}, {SPE, 120}, {T1, 11}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 55}, {ATK, 50}, {DEF, 45}, {VIT, 120}, {SPE, 135}, {T1, 11}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 70}, {ATK, 80}, {DEF, 50}, {VIT, 35}, {SPE, 35}, {T1, 7}, {T2, 7}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 100}, {DEF, 70}, {VIT, 45}, {SPE, 50}, {T1, 7}, {T2, 7}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 90}, {ATK, 130}, {DEF, 80}, {VIT, 55}, {SPE, 65}, {T1, 7}, {T2, 7}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 75}, {DEF, 35}, {VIT, 40}, {SPE, 70}, {T1, 3}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 90}, {DEF, 50}, {VIT, 55}, {SPE, 85}, {T1, 3}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 105}, {DEF, 65}, {VIT, 70}, {SPE, 100}, {T1, 3}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 40}, {DEF, 35}, {VIT, 70}, {SPE, 100}, {T1, 1}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 70}, {DEF, 65}, {VIT, 100}, {SPE, 120}, {T1, 1}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 80}, {DEF, 100}, {VIT, 20}, {SPE, 30}, {T1, 13}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 95}, {DEF, 115}, {VIT, 35}, {SPE, 45}, {T1, 13}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 110}, {DEF, 130}, {VIT, 45}, {SPE, 55}, {T1, 13}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 55}, {ATK, 85}, {DEF, 55}, {VIT, 90}, {SPE, 65}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 100}, {DEF, 70}, {VIT, 105}, {SPE, 80}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 65}, {DEF, 95}, {VIT, 15}, {SPE, 40}, {T1, 2}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 75}, {DEF, 55}, {VIT, 30}, {SPE, 80}, {T1, 2}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 25}, {ATK, 35}, {DEF, 70}, {VIT, 45}, {SPE, 95}, {T1, 5}, {T2, 5}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 60}, {DEF, 95}, {VIT, 70}, {SPE, 120}, {T1, 5}, {T2, 5}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 52}, {ATK, 65}, {DEF, 55}, {VIT, 60}, {SPE, 58}, {T1, 0}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 35}, {ATK, 85}, {DEF, 45}, {VIT, 75}, {SPE, 35}, {T1, 0}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 110}, {DEF, 70}, {VIT, 100}, {SPE, 60}, {T1, 0}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 45}, {DEF, 55}, {VIT, 45}, {SPE, 70}, {T1, 2}, {T2, 2}}); 
            pokeStat.Add(new Dictionary<string, int>(){{HP, 90}, {ATK, 70}, {DEF, 80}, {VIT, 70}, {SPE, 95}, {T1, 2}, {T2, 6}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 80}, {DEF, 50}, {VIT, 25}, {SPE, 40}, {T1, 8}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 105}, {ATK, 105}, {DEF, 75}, {VIT, 50}, {SPE, 65}, {T1, 8}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 30}, {ATK, 65}, {DEF, 100}, {VIT, 40}, {SPE, 45}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 95}, {DEF, 180}, {VIT, 70}, {SPE, 85}, {T1, 2}, {T2, 6}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 30}, {ATK, 35}, {DEF, 30}, {VIT, 80}, {SPE, 100}, {T1, 14}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 45}, {ATK, 50}, {DEF, 45}, {VIT, 95}, {SPE, 115}, {T1, 14}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 65}, {DEF, 60}, {VIT, 110}, {SPE, 130}, {T1, 14}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 35}, {ATK, 45}, {DEF, 160}, {VIT, 70}, {SPE, 30}, {T1, 13}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 48}, {DEF, 45}, {VIT, 42}, {SPE, 90}, {T1, 11}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 85}, {ATK, 73}, {DEF, 70}, {VIT, 67}, {SPE, 115}, {T1, 11}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 30}, {ATK, 105}, {DEF, 90}, {VIT, 50}, {SPE, 25}, {T1, 2}, {T2, 2}}); 
            pokeStat.Add(new Dictionary<string, int>(){{HP, 55}, {ATK, 130}, {DEF, 115}, {VIT, 75}, {SPE, 50}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 30}, {DEF, 50}, {VIT, 100}, {SPE, 55}, {T1, 5}, {T2, 5}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 50}, {DEF, 70}, {VIT, 140}, {SPE, 80}, {T1, 5}, {T2, 5}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 40}, {DEF, 80}, {VIT, 40}, {SPE, 60}, {T1, 3}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 95}, {ATK, 95}, {DEF, 85}, {VIT, 55}, {SPE, 125}, {T1, 3}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 50}, {DEF, 95}, {VIT, 35}, {SPE, 40}, {T1, 9}, {T2, 9}}); 
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 80}, {DEF, 110}, {VIT, 45}, {SPE, 50}, {T1, 9}, {T2, 9}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 120}, {DEF, 53}, {VIT, 87}, {SPE, 35}, {T1, 7}, {T2, 7}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 50}, {ATK, 105}, {DEF, 79}, {VIT, 76}, {SPE, 35}, {T1, 7}, {T2, 7}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 90}, {ATK, 55}, {DEF, 75}, {VIT, 30}, {SPE, 60}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 65}, {DEF, 95}, {VIT, 35}, {SPE, 60}, {T1, 8}, {T2, 8}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 90}, {DEF, 120}, {VIT, 60}, {SPE, 85}, {T1, 9}, {T2, 13}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 85}, {DEF, 95}, {VIT, 25}, {SPE, 30}, {T1, 9}, {T2, 13}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 105}, {ATK, 130}, {DEF, 120}, {VIT, 40}, {SPE, 45}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 250}, {ATK, 5}, {DEF, 5}, {VIT, 50}, {SPE, 105}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 55}, {DEF, 115}, {VIT, 60}, {SPE, 100}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 105}, {ATK, 95}, {DEF, 80}, {VIT, 90}, {SPE, 40}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 30}, {ATK, 40}, {DEF, 70}, {VIT, 60}, {SPE, 70}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 55}, {ATK, 65}, {DEF, 95}, {VIT, 85}, {SPE, 85}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 45}, {ATK, 67}, {DEF, 60}, {VIT, 63}, {SPE, 50}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 92}, {DEF, 65}, {VIT, 68}, {SPE, 80}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 30}, {ATK, 45}, {DEF, 55}, {VIT, 85}, {SPE, 70}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 75}, {DEF, 85}, {VIT, 115}, {SPE, 100}, {T1, 2}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 40}, {ATK, 45}, {DEF, 65}, {VIT, 90}, {SPE, 100}, {T1, 11}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 70}, {ATK, 110}, {DEF, 80}, {VIT, 105}, {SPE, 55}, {T1, 12}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 50}, {DEF, 35}, {VIT, 95}, {SPE, 95}, {T1, 6}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 83}, {DEF, 57}, {VIT, 105}, {SPE, 85}, {T1, 5}, {T2, 5}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 95}, {DEF, 57}, {VIT, 93}, {SPE, 85}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 125}, {DEF, 100}, {VIT, 85}, {SPE, 55}, {T1, 12}, {T2, 12}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 75}, {ATK, 100}, {DEF, 95}, {VIT, 110}, {SPE, 70}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 20}, {ATK, 10}, {DEF, 55}, {VIT, 80}, {SPE, 20}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 95}, {ATK, 125}, {DEF, 79}, {VIT, 81}, {SPE, 100}, {T1, 2}, {T2, 12}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 130}, {ATK, 85}, {DEF, 80}, {VIT, 60}, {SPE, 95}, {T1, 2}, {T2, 6}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 48}, {ATK, 48}, {DEF, 48}, {VIT, 48}, {SPE, 48}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 55}, {ATK, 55}, {DEF, 50}, {VIT, 55}, {SPE, 65}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 130}, {ATK, 65}, {DEF, 60}, {VIT, 65}, {SPE, 110}, {T1, 2}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK,65 }, {DEF, 60}, {VIT, 130}, {SPE, 110}, {T1, 5}, {T2, 5}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 130}, {DEF, 60}, {VIT, 65}, {SPE, 110}, {T1, 1}, {T2, 1}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 65}, {ATK, 60}, {DEF, 70}, {VIT, 40}, {SPE, 75}, {T1, 0}, {T2, 0}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 35}, {ATK, 40}, {DEF, 100}, {VIT, 35}, {SPE, 90}, {T1, 13}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 70}, {ATK, 60}, {DEF, 125}, {VIT, 55}, {SPE, 115}, {T1, 13}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 30}, {ATK, 80}, {DEF, 90}, {VIT, 55}, {SPE, 45}, {T1, 13}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 60}, {ATK, 115}, {DEF, 105}, {VIT, 80}, {SPE, 70}, {T1, 13}, {T2, 2}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 80}, {ATK, 105}, {DEF, 65}, {VIT, 130}, {SPE, 60}, {T1, 13}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 160}, {ATK, 110}, {DEF, 65}, {VIT, 30}, {SPE, 65}, {T1, 6}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 90}, {ATK, 85}, {DEF, 100}, {VIT, 85}, {SPE, 125}, {T1, 6}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 90}, {ATK, 90}, {DEF, 85}, {VIT, 100}, {SPE, 125}, {T1, 5}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 90}, {ATK, 100}, {DEF, 90}, {VIT, 90}, {SPE, 125}, {T1, 1}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 41}, {ATK, 64}, {DEF, 45}, {VIT, 90}, {SPE, 50}, {T1, 15}, {T2, 15}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 61}, {ATK, 84}, {DEF, 65}, {VIT, 50}, {SPE, 70}, {T1, 15}, {T2, 15}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 91}, {ATK, 134}, {DEF, 95}, {VIT, 70}, {SPE, 100}, {T1, 15}, {T2, 10}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 106}, {ATK, 110}, {DEF, 90}, {VIT, 80}, {SPE, 154}, {T1, 11}, {T2, 11}});
            pokeStat.Add(new Dictionary<string, int>(){{HP, 100}, {ATK, 100}, {DEF, 100}, {VIT, 130}, {SPE, 100}, {T1, 11}, {T2, 11}});


            pokeName = new List<string>();
            pokeName.Add("Bulbasaur");
            pokeName.Add("Ivysaur");
            pokeName.Add("Venusaur");
            pokeName.Add("Charmander");
            pokeName.Add("Charmeleon");
            pokeName.Add("Charizard");
            pokeName.Add("Squirtle");
            pokeName.Add("Wartortle");
            pokeName.Add("Blastoise");
            pokeName.Add("Caterpie");
            pokeName.Add("Metapod");
            pokeName.Add("Butterfree");
            pokeName.Add("Weedle");
            pokeName.Add("Kakuna");
            pokeName.Add("Beedrill");
            pokeName.Add("Pidgey");
            pokeName.Add("Pidgeotto");
            pokeName.Add("Rattata");
            pokeName.Add("Raticate");
            pokeName.Add("Spearow");
            pokeName.Add("Fearow");
            pokeName.Add("Ekans");
            pokeName.Add("Arbok");
            pokeName.Add("Pikachu");
            pokeName.Add("Raichu");
            pokeName.Add("Sandshrew");
            pokeName.Add("Sandslash");
            pokeName.Add("Nidoran(f)");
            pokeName.Add("Nidorina");
            pokeName.Add("Nidoqueen");
            pokeName.Add("Nidoran(m)");
            pokeName.Add("Nidorino");
            pokeName.Add("Nidoking");
            pokeName.Add("Clefairy");
            pokeName.Add("Clefable");
            pokeName.Add("Vulpix");
            pokeName.Add("Ninetales");
            pokeName.Add("Jigglypuff");
            pokeName.Add("Wigglytuff");
            pokeName.Add("Zubat");
            pokeName.Add("Golbat");
            pokeName.Add("Oddish");
            pokeName.Add("Gloom");
            pokeName.Add("Vileplume");
            pokeName.Add("Paras");
            pokeName.Add("Parasect");
            pokeName.Add("Venonat");
            pokeName.Add("Venomoth");
            pokeName.Add("Diglet");
            pokeName.Add("Dugtrio");
            pokeName.Add("Meowth");
            pokeName.Add("Persian");
            pokeName.Add("Psyduck");
            pokeName.Add("Golduck");
            pokeName.Add("Mankey");
            pokeName.Add("Primeape");
            pokeName.Add("Growlith");
            pokeName.Add("Arcanine");
            pokeName.Add("Poliwag");
            pokeName.Add("Poliwhirl");
            pokeName.Add("Poliwrath");
            pokeName.Add("Abra");
            pokeName.Add("Kadabra");
            pokeName.Add("Alakazam");
            pokeName.Add("Machop");
            pokeName.Add("Machoke");
            pokeName.Add("Machamp");
            pokeName.Add("Bellsprout");
            pokeName.Add("Weepinbell");
            pokeName.Add("Victreebel");
            pokeName.Add("Tentacool");
            pokeName.Add("Tentacruel");
            pokeName.Add("Geodude");
            pokeName.Add("Graveler");
            pokeName.Add("Golem");
            pokeName.Add("Ponyta");
            pokeName.Add("Rapiddash");
            pokeName.Add("Slowpoke");
            pokeName.Add("Slowbro");
            pokeName.Add("Magnemite");
            pokeName.Add("Magneton");
            pokeName.Add("Farfetch'd");
            pokeName.Add("Doduo");
            pokeName.Add("Dodrio");
            pokeName.Add("Seel");
            pokeName.Add("Dewgong");
            pokeName.Add("Grimer");
            pokeName.Add("Muk");
            pokeName.Add("Shellder");
            pokeName.Add("Cloyster");
            pokeName.Add("Gastly");
            pokeName.Add("Haunter");
            pokeName.Add("Gengar");
            pokeName.Add("Onix");
            pokeName.Add("Drowzee");
            pokeName.Add("Hypno");
            pokeName.Add("Krabby");
            pokeName.Add("Kingler");
            pokeName.Add("Voltorb");
            pokeName.Add("Electrode");
            pokeName.Add("Exeggcute");
            pokeName.Add("Exeggutor");
            pokeName.Add("Cubone");
            pokeName.Add("Marowak");
            pokeName.Add("Hitmonlee");
            pokeName.Add("Hitmonchan");
            pokeName.Add("Licktung");
            pokeName.Add("Koffing");
            pokeName.Add("Weezing");
            pokeName.Add("Rhyhorn");
            pokeName.Add("Rhydon");
            pokeName.Add("Chansey");
            pokeName.Add("Tangela");
            pokeName.Add("Kangaskhan");
            pokeName.Add("Horsea");
            pokeName.Add("Seadra");
            pokeName.Add("Goldeen");
            pokeName.Add("Seaking");
            pokeName.Add("Staryu");
            pokeName.Add("Starmie");
            pokeName.Add("Mr.Mime");
            pokeName.Add("Scyther");
            pokeName.Add("Jynx");
            pokeName.Add("Electabuzz");
            pokeName.Add("Magmar");
            pokeName.Add("Pinsir");
            pokeName.Add("Tauros");
            pokeName.Add("Magikarp");
            pokeName.Add("Gyarados");
            pokeName.Add("Lapras");
            pokeName.Add("Ditto");
            pokeName.Add("Eevee");
            pokeName.Add("Vaporeon");
            pokeName.Add("Jolteon");
            pokeName.Add("Flareon");
            pokeName.Add("Porygon");
            pokeName.Add("Omanyte");
            pokeName.Add("Omastar");
            pokeName.Add("Kabuto");
            pokeName.Add("Kabutops");
            pokeName.Add("Areodactyl");
            pokeName.Add("Snorlax");
            pokeName.Add("Articuno");
            pokeName.Add("Zapdos");
            pokeName.Add("Moltres");
            pokeName.Add("Dratini");
            pokeName.Add("Dragonair");
            pokeName.Add("Dragonite");
            pokeName.Add("Mewtow");
            pokeName.Add("Mew");
            
            pokeAttack = new List<Attack>();
            pokeAttack.Add(new Attack("Cut", "A useful combat attack", Attack.Poketype.NORMAL, 10));
            pokeAttack.Add(new Attack("Surf", "a classic", Attack.Poketype.EAU, 20));
            
        }

        public Pokemon GetPokemon(int i)
        {
            string name = pokeName[i];
            Dictionary<string, int> stat = pokeStat[i];
            List<Attack> atks = new List<Attack>(){pokeAttack[0], pokeAttack[1]};
            return new Pokemon(name, stat, atks);
        }


        public Pokemon GetRandomPokemon()
        {
            Random r = new Random();
            int i = r.Next(pokeName.Count());
            return new Pokemon(pokeName[i], pokeStat[i], new List<Attack> {pokeAttack[0]});
        }
    }
}