using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Races.EnemyRaces
{
    internal class Goblin : Race
    {
        public Goblin()
        {
            this.HealthMultiplier = 0.75;
            this.DamageMultiplier = 1;
            this.SpeedMultiplier = 1.50;
        }
    }
}
