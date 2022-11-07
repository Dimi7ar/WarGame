using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Races.PlayerRaces
{
    internal class Dragon : Race
    {
        public Dragon()
        {
            this.HealthMultiplier = 1.30;
            this.DamageMultiplier = 1.25;
            this.SpeedMultiplier = 0.75;
        }
    }
}
