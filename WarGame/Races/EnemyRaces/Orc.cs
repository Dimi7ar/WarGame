using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Races.EnemyRaces
{
    internal class Orc : Race
    {
        public Orc()
        {
            this.HealthMultiplier = 1;
            this.DamageMultiplier = 1.15;
            this.SpeedMultiplier = 1.15;
        }
    }
}
