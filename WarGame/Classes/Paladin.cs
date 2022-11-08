namespace WarGame.Classes
{

    internal class Paladin : Class
    {
        private Random random = new Random();
        public Paladin()
        {
            this.Health = random.Next(100, 200);
            this.Damage = random.Next(20, 40);
            this.Speed = random.Next(1, 10);
            this.CanHeal = true;
        }
    }
}
