using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Classes
{

    internal class Paladin : Class
    {
        Random random = new Random();
        public Paladin() : base()
        {
            Health = random.Next(1, 100);
            damage = random.Next(1, 100);
            speed = random.Next(1, 100);
            canHeal = true;
        }
    }
}
