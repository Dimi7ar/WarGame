using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Classes;
using WarGame.Races;
using WarGame.Races.PlayerRaces;
using WarGame.Units;
using Console = System.Console;

namespace WarGame
{
    internal class CreateCharacter
    {

        public static PlayerUnit Create(int num)
        {
            Race race;
            Class unitClass;
            race = ChooseRace(num);
            unitClass = ChooseClass(num);

            return new PlayerUnit(race, unitClass);
        }

        public static Race ChooseRace(int num)
        {
            string message = $"Hero {num}\nWhat race do you want your hero to be?\n(races can increase or decrease the stats of your hero)";
            int choice = ConsoleChoice.Choice(message, "Human", "Elf", "Gnome", "Dragon");
            Race race = choice == 0 ? new Human() :
                choice == 1 ? new Elf() :
                choice == 2 ? new Gnome() :
                choice == 3 ? new Dragon() : throw new Exception("Invalid input");
            return race;
        }
        public static Class ChooseClass(int num)
        {
             string message = $"Hero {num}\nWhat class shall they be?";
             int choice = ConsoleChoice.Choice(message, "Warrior", "Archer", "Paladin", "Priest");
             Class unitClass = choice == 0 ? new Warrior() :
                 choice == 1 ? new Archer() :
                 choice == 2 ? new Paladin() :
                 choice == 3 ? new Priest() : throw new Exception("Invalid input");
             return unitClass;
        }
         
    }
}
