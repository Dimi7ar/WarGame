using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Races.EnemyRaces
{
    internal class Undead  :Race
    {
        public Undead()
        {
            this.HealthMultiplier = 0.75;
            this.DamageMultiplier = 1.25;
            this.SpeedMultiplier = 1.25;
        }
    }
}
