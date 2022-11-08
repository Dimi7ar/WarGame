using System.Text;
using WarGame.Units;

namespace WarGame
{
    public class StartGame
    {
        private static List<PlayerUnit> playerTeam = new List<PlayerUnit>();
        private static List<EnemyUnit> enemyTeam = new List<EnemyUnit>();

        public static void Start()
        {
            string message = "How many heroes do you want on your team?";
            int choice = ConsoleChoice.Choice(message, "1", "2", "3", "4") + 1;
            for (int i = 0; i < choice; i++)
            {
                playerTeam.Add(CreateCharacter.Create(i+1));
                enemyTeam.Add(new EnemyUnit());
            }
        }

        public static void Round()
        {
            if (enemyTeam.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("You win!");
                Console.CursorVisible = true;
            }
            else if (playerTeam.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("You lose :(");
                Console.CursorVisible = true;
            } 
            else 
            {
                foreach (var unit in playerTeam)
                {
                    string art = Art();
                    EnemyUnit enemy = enemyTeam.First();
                    string message = art + "\nChoose an action:";
                    if (unit.UnitClass.GetType().Name == "Paladin")
                    {
                        int choice = ConsoleChoice.Choice(message, "Attack", "Heal", "Skip");
                        switch (choice)
                        {
                            case 0:
                                Console.WriteLine("Enemy " + unit.Attack(enemy));
                                break;
                            case 1:
                                Console.WriteLine(unit.Heal(unit));
                                break;
                            case 2:
                                break;
                        }
                    }
                    else if (unit.UnitClass.GetType().Name == "Priest")
                    {
                        int choice = ConsoleChoice.Choice(message, "Attack", "Heal", "Skip");
                        switch (choice)
                        {
                            case 0:
                                Console.WriteLine("Enemy " + unit.Attack(enemy));
                                break;
                            case 1:
                                Console.WriteLine(unit.Heal(playerTeam.First()));
                                break;
                            case 2:
                                break;
                        }
                    }
                    else
                    {
                        int choice = ConsoleChoice.Choice(message, "Attack", "Skip");
                        switch (choice)
                        {
                            case 0:
                                Console.WriteLine("Enemy " + unit.Attack(enemy));
                                break;
                            case 2:
                                break;
                        }
                    }

                    if (enemy.Health <= 0)
                    {
                        Console.WriteLine("Enemy " + enemy.UnitClass.GetType().Name + " died.");
                        enemyTeam.RemoveAt(0);
                    }
                    Thread.Sleep(3000);
                }
                if (enemyTeam.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You win!");
                    Console.CursorVisible = true;
                }
                else if (playerTeam.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You lose :(");
                    Console.CursorVisible = true;
                }
                else
                {
                    foreach (var unit in enemyTeam)
                    {
                        PlayerUnit enemy = playerTeam.First();
                        Console.WriteLine("Your " + unit.Attack(enemy));
                        if (enemy.Health <= 0)
                        {
                            Console.WriteLine("Your " + enemy.UnitClass.GetType().Name + " died.");
                            playerTeam.RemoveAt(0);
                        }
                        Thread.Sleep(3000);
                    }
                }
            }
        }

        public static string Art()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Player team:");
            foreach (var player in playerTeam)
            {
                sb.AppendLine($"{player.UnitClass.GetType().Name} - {player.Health}");
            }
            sb.AppendLine();
            sb.AppendLine("Enemy team:");
            foreach (var enemy in enemyTeam)
            {
                sb.AppendLine($"{enemy.UnitClass.GetType().Name} - {enemy.Health}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
