using System.Runtime.CompilerServices;
using WarGame.Interfaces;

namespace WarGame.Classes
{
    internal class Class : IClass
    {
        private int health;
        private int damage;
        private int speed;
        private bool canHeal;

        public Class()
        {

        }
        public int Health { get; set; }

        public int Damage
        {
            get => damage;
            private set
            {
                damage = value;
            }
        }
        public int Speed
        {
            get => speed;
            private set
            {
                speed = value;
            }
        }
        public bool CanHeal
        {
            get => canHeal;
            private set
            {
                canHeal = value;
            }
        }

    }
}
