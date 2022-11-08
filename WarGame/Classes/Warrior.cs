namespace WarGame.Classes
{

    internal class Warrior : Class
    {
        private Random random = new Random();
        public Warrior()
        {
            this.Health = random.Next(100, 150);
            this.Damage = random.Next(70, 100);
            this.Speed = random.Next(1, 10);
            this.CanHeal = false;
        }
    }
}