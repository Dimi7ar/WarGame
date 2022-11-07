using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Races.PlayerRaces
{
    internal class Gnome : Race
    {
        public Gnome()
        {
            this.HealthMultiplier = 0.75;
            this.DamageMultiplier = 0.95;
            this.SpeedMultiplier = 1.50;
        }
    }
}
