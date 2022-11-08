using WarGame.Classes;
using WarGame.Races;
using WarGame.Races.EnemyRaces;

namespace WarGame.Units
{
    internal class EnemyUnit : Unit
    {
        //Enemies can only be a class of Warrior or Archer
        //Enemies can only be one of EnemyRaces
        private Random random = new Random();
        public EnemyUnit()
        {
            int classFlag = random.Next(1,3);
            Console.WriteLine(classFlag);
            Class unitClass = classFlag == 1 ? new Warrior() : new Archer();
            int raceFlag = random.Next(1,5);
            Console.WriteLine(raceFlag);
            Race race = raceFlag == 1 ? new Demon() : raceFlag == 2 ? new Goblin() : raceFlag == 3 ? new Orc() : new Undead();

            this.UnitClass = unitClass;
            this.Race = race;
            this.Health = Math.Round(unitClass.Health * race.HealthMultiplier, 2);
            this.Damage = Math.Round(unitClass.Damage * race.DamageMultiplier, 2);
            this.Speed = Math.Round(unitClass.Speed * race.SpeedMultiplier, 2);
        }
    }
}
