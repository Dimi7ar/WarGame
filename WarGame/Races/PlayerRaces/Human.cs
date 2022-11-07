using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Races.PlayerRaces
{
    internal class Human : Race
    {
        public Human()
        {
            this.HealthMultiplier = 1.10;
            this.DamageMultiplier = 1.10;
            this.SpeedMultiplier = 1.10;
        }
    }
}
