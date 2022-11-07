using WarGame.Classes;
using WarGame.Races;

namespace WarGame.Units
{
    internal class Unit
    {
        private double health;
        private double damage;
        private double speed;
        public Class UnitClass { get; set; }
        public Race Race { get; set; }

        public double Health
        {
            get => health;
            private set
            {
                health = UnitClass.Health * Race.HealthMultiplier;
            }
        }
        public double Damage
        {
            get => damage;
            private set
            {
                damage = UnitClass.Damage * Race.DamageMultiplier;
            }
        }
        public double Speed
        {
            get => speed;
            private set
            {
                speed = UnitClass.Speed * Race.SpeedMultiplier;
            }
        }

        public void LevelUp()
        {
            Health *= 1.01;
            Damage *= 1.01;
            Speed *= 1.01;
        }
    }
}
