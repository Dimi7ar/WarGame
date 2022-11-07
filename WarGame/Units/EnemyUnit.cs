using WarGame.Classes;
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
            int classFlag = random.Next(1,2);
            this.UnitClass = classFlag == 1 ? new Warrior() : new Archer();
            int raceFlag = random.Next(1, 4);
            this.Race = raceFlag == 1 ? new Demon() : raceFlag == 2 ? new Goblin() : raceFlag == 3 ? new Orc() : new Undead();
        }
    }
}
