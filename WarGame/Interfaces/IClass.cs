using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Interfaces
{
    internal interface IClass
    {
        //A character class can be:
        //Paladin - Tank
        //Warrior - Damage dealer
        //Archer - Long range damage dealer (less damage than warrior but harder to hit)
        //Priest - Healer

        //A class can have:
        //Health
        //Damage
        //Speed (% chance to dodge an attack)
        //CanHeal

        int Health { get; }
        int Damage { get; }
        int Speed { get; }
        bool CanHeal { get; }
    }
}
