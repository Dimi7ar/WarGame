namespace WarGame.Classes
{

    internal class Priest : Class
    {
        private Random random = new Random();
        public Priest()
        {
            this.Health = random.Next(80, 100);
            this.Damage = random.Next(20, 30);
            this.Speed = random.Next(30, 40);
            this.CanHeal = true;
        }
    }
}