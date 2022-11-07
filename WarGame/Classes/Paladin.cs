﻿namespace WarGame.Classes
{

    internal class Paladin : Class
    {
        private Random random = new Random();
        public Paladin()
        {
            this.Health = random.Next(1, 100);
            this.Damage = random.Next(1, 100);
            this.Speed = random.Next(1, 100);
            this.CanHeal = true;
        }
    }
}
