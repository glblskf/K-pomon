using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;

namespace Pokemonbonus
{
    public class Attack
    {
        private string _name;
        private string _description;
        private Poketype _attackType;

        public Attack(string name, string description, Poketype attackType)
        {
            _name = name;
            _description = description;
            _attackType = attackType;
        }

        public enum Poketype
        {
            NORMAL,
            FEU,
            EAU,
            PLANTE,
            ELECTICK,
            GLACE,
            COMBAT,
            POISON,
            SOL,
            VOL,
            PSY,
            INSCECTE,
            ROCHE,
            SPECTRE,
            DRAGON
        }

        public float GetMultiplier(Poketype enemyType)
        {
            switch (_attackType) // Attack Type
            {
                case Poketype.NORMAL:
                    switch (enemyType)
                    {
                        case Poketype.ROCHE:
                            return 0.5f;
                        case Poketype.SPECTRE:
                            return 0;
                        default:
                            return 1;
                    }
                case Poketype.FEU:
                    switch (enemyType)
                    {
                        case Poketype.FEU:
                            return 0.5f; // Pour une raison obscure, il n'accepte pas que le feu soit avec les autres...
                        case Poketype.EAU : case Poketype.ROCHE : case Poketype.DRAGON:
                            return 0.5f;
                        case Poketype.PLANTE : case Poketype.GLACE : case Poketype.INSCECTE:
                            return 2;
                        default:
                            return 1;
                    }
                case Poketype.EAU:
                    switch (enemyType)
                    {
                        case Poketype.EAU : case Poketype.PLANTE : case Poketype.DRAGON:
                            return 0.5f;
                        case Poketype.FEU : case Poketype.SOL : case Poketype.ROCHE:
                            return 2;
                        default:
                            return 1;
                    }
                case Poketype.PLANTE:
                    switch (enemyType)
                    {
                        case Poketype.FEU : case Poketype.PLANTE : case Poketype.DRAGON:
                            return 0.5f;
                        case Poketype.EAU : case Poketype.SOL : case Poketype.ROCHE:
                            return 2;
                        default:
                            return 1;
                    }
                case Poketype.ELECTICK:
                    switch (enemyType)
                    {
                        case Poketype.PLANTE : case Poketype.ELECTICK : case Poketype.DRAGON:
                            return 0.5f;
                        case Poketype.EAU : case Poketype.VOL:
                            return 2;
                        case Poketype.SOL:
                            return 0;
                        default:
                            return 1;
                    }
                case Poketype.GLACE:
                    switch (enemyType)
                    {
                        case Poketype.EAU : case Poketype.GLACE:
                            return 0.5f;
                        case Poketype.PLANTE : case Poketype.SOL : case Poketype.VOL : case Poketype.DRAGON:
                            return 2;
                        default:
                            return 1;
                    }
                case Poketype.COMBAT:
                    switch (enemyType)
                    {
                        case Poketype.POISON : case Poketype.VOL : case Poketype.PSY : case Poketype.INSCECTE:
                            return 0.5f;
                        case Poketype.NORMAL : case Poketype.GLACE:
                            return 2;
                        case Poketype.ROCHE:
                            return 2;
                        case Poketype.SPECTRE:
                            return 0;
                        default:
                            return 1;
                    }
                case Poketype.POISON:
                    switch (enemyType)
                    {
                        case Poketype.POISON : case Poketype.SOL : case Poketype.ROCHE : case Poketype.SPECTRE:
                            return 0.5f;
                        case Poketype.PLANTE : case Poketype.INSCECTE:
                            return 2;
                        default:
                            return 1;
                    }
                case Poketype.SOL:
                    switch (enemyType)
                    {
                        case Poketype.PLANTE : case Poketype.INSCECTE:
                            return 0.5f;
                        case Poketype.FEU : case Poketype.ELECTICK : case Poketype.POISON : case Poketype.ROCHE:
                            return 2;
                        case Poketype.VOL:
                            return 0;
                        default:
                            return 1;
                    }
                case Poketype.VOL:
                    switch (enemyType)
                    {
                        case Poketype.ELECTICK : case Poketype.ROCHE:
                            return 0.5f;
                        case Poketype.PLANTE : case Poketype.COMBAT : case Poketype.INSCECTE:
                            return 2;
                        default:
                            return 1;
                    }
                case Poketype.PSY:
                    switch (enemyType)
                    {
                        case Poketype.PSY:
                            return 0.5f;
                        case Poketype.COMBAT : case Poketype.POISON:
                            return 2;
                        default:
                            return 1;
                    }
                case Poketype.INSCECTE:
                    switch (enemyType)
                    {
                        case Poketype.COMBAT:
                            return 0.5f;
                        case Poketype.FEU : case Poketype.VOL : case Poketype.SPECTRE:
                            return 0.5f;
                        case Poketype.PLANTE : case Poketype.POISON : case Poketype.PSY:
                            return 2;
                        default:
                            return 1;
                    }
                case Poketype.ROCHE:
                    switch (enemyType)
                    {
                        case Poketype.COMBAT : case Poketype.SOL:
                            return 0.5f;
                        case Poketype.FEU : case Poketype.GLACE : case Poketype.VOL : case Poketype.INSCECTE:
                            return 2;
                        default:
                            return 1;
                    }
                case Poketype.SPECTRE:
                    switch (enemyType)
                    {
                        case Poketype.SPECTRE:
                            return 2;
                        case Poketype.NORMAL : case Poketype.PSY:
                            return 0;
                        default :
                            return 1;
                    }
                case Poketype.DRAGON:
                    switch (enemyType)
                    {
                        case Poketype.DRAGON:
                            return 2;
                        default:
                            return 1;
                    }
                default:
                    throw new Exception("Poketype non implemented");
            }
        }
    }
}