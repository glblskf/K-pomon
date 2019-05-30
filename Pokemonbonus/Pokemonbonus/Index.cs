using System;
using System.Collections.Generic;

namespace Pokemonbonus
{
    public class Index
    {
        private string HP = "HP";
        private string ATK = "FORCE";
        private string DEF = "DEFENSE";
        private string VIT = "VITESSE";
        private string SPE = "SPECIAL";
        private List<Dictionary<string, int>> pokeStat;
        private List<string> pokeName;

        public Index()
        {
            List<Dictionary<string, int>> pokeStat = new List<Dictionary<string, int>>();
            pokeStat.Add(new Dictionary<string, int>() {{HP, 45}, {ATK, 49}, {DEF, 49}, {VIT, 45}, {SPE, 65}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 45}, {ATK, 62}, {DEF, 63}, {VIT, 60}, {SPE, 80}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 80}, {ATK, 83}, {DEF, 83}, {VIT, 80}, {SPE, 100}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 39}, {ATK, 52}, {DEF, 43}, {VIT, 65}, {SPE, 50}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 58}, {ATK, 64}, {DEF, 58}, {VIT, 85}, {SPE, 65}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 78}, {ATK, 84}, {DEF, 78}, {VIT, 100}, {SPE, 85}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 44}, {ATK, 48}, {DEF, 65}, {VIT, 43}, {SPE, 50}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 59}, {ATK, 63}, {DEF, 80}, {VIT, 58}, {SPE, 65}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 78}, {ATK, 83}, {DEF, 100}, {VIT, 78}, {SPE, 85}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 45}, {ATK, 30}, {DEF, 35}, {VIT, 45}, {SPE, 20}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 50}, {ATK, 20}, {DEF, 55}, {VIT, 20}, {SPE, 25}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 60}, {ATK, 45}, {DEF, 50}, {VIT, 70}, {SPE, 80}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 40}, {ATK, 35}, {DEF, 30}, {VIT, 50}, {SPE, 20}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 45}, {ATK, 25}, {DEF, 50}, {VIT, 35}, {SPE, 25}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 65}, {ATK, 80}, {DEF, 40}, {VIT, 75}, {SPE, 45}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 40}, {ATK, 45}, {DEF, 40}, {VIT, 56}, {SPE, 35}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 63}, {ATK, 60}, {DEF, 55}, {VIT, 71}, {SPE, 50}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 83}, {ATK, 80}, {DEF, 75}, {VIT, 91}, {SPE, 70}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 30}, {ATK, 56}, {DEF, 35}, {VIT, 72}, {SPE, 25}});
            pokeStat.Add(new Dictionary<string, int>() {{HP, 55}, {ATK, 81}, {DEF, 60}, {VIT, 97}, {SPE, 50}});

            List<string> pokeName = new List<string>();
            pokeName.Add("Bulbasaur");
        }
        
        
    }
}