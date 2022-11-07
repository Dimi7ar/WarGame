using WarGame.Classes;
using WarGame.Races;

namespace WarGame.Units
{
    internal class PlayerUnit : Unit
    {
        //Players can be any class
        //Players can only be one of PlayerRaces
        public PlayerUnit(Class unitClass, Race race)
        {
            this.UnitClass = unitClass;
            this.Race = race;
        }
    }
}
