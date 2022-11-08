using WarGame.Classes;
using WarGame.Races;

namespace WarGame.Units
{
    internal class PlayerUnit : Unit
    {
        //Players can be any class
        //Players can only be one of PlayerRaces
        public PlayerUnit(Race race, Class unitClass)
        {
            this.Race = race;
            this.UnitClass = unitClass;
            this.Health = Math.Round(unitClass.Health * race.HealthMultiplier, 2);
            this.Damage = Math.Round(unitClass.Damage * race.DamageMultiplier, 2);
            this.Speed = Math.Round(unitClass.Speed * race.SpeedMultiplier, 2);
        }
    }
}
