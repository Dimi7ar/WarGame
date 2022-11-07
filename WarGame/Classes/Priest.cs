namespace WarGame.Classes
{

    internal class Priest : Class
    {
        private Random random = new Random();
        public Priest()
        {
            this.Health = random.Next(1, 100);
            this.Damage = random.Next(1, 100);
            this.Speed = random.Next(1, 100);
            this.CanHeal = true;
        }
    }
}