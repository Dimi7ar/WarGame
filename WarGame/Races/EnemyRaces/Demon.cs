using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Races.EnemyRaces
{
    internal class Demon : Race
    {
        public Demon()
        {
            this.HealthMultiplier = 1.30;
            this.DamageMultiplier = 1.10;
            this.SpeedMultiplier = 0.95;
        }
    }
}
