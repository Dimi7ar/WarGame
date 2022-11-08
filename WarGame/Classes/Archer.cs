namespace WarGame.Classes
{

    internal class Archer : Class
    {
        private Random random = new Random();
        public Archer()
        {
            this.Health = random.Next(50, 60);
            this.Damage = random.Next(60, 70);
            this.Speed = random.Next(40, 50);
            this.CanHeal = false;
        }
    }
}