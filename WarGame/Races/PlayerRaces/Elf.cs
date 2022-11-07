using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Races.PlayerRaces
{
    internal class Elf : Race
    {
        public Elf()
        {
            this.HealthMultiplier = 0.90;
            this.DamageMultiplier = 1.20;
            this.SpeedMultiplier = 1.20;
        }
    }
}
