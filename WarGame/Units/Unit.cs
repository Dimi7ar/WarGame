using WarGame.Classes;
using WarGame.Races;

namespace WarGame.Units
{
    internal class Unit
    {
        public double health;
        public double damage;
        public double speed;
        public Class UnitClass { get; set; }
        public Race Race { get; set; }

        
        public double Health
        {
            get => health;
            set => health = value;
        }
        public double Damage
        {
            get => damage;
            set => damage = value;
        }
        public double Speed
        {
            get => speed;
            set => speed = value;
        }

        //public void LevelUp()
        //{
        //    Health *= 1.01;
        //    Damage *= 1.01;
        //    Speed *= 1.01;
        //}

        public string Attack(Unit enemy)
        {
            Random random = new Random();
            double dodgeChance = enemy.Speed;
            if (random.Next(0,100) > dodgeChance)
            {
               enemy.Health -= Damage;
            }
            else
            {
                enemy.Speed -= 15;
                return $"{enemy.UnitClass.GetType().Name} dodged.";
            }
            return $"{enemy.UnitClass.GetType().Name} took {Damage} damage.";

        }

        public string Heal(Unit player)
        {
            player.Health += player.Health * 0.20;
            
            return $"{player.UnitClass.GetType().Name} healed for {player.Health * 0.20}.";
        }
    }
}
