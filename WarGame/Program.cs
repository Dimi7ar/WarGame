using WarGame;
internal class Program
{

    private static bool isRunning = true;

    private static void Main(string[] args)
    {

        Init();

        while (isRunning)
        {
            CheckKeyboardInput();

            StartGame.Round();

            DelayGameLoop();
        }

        Console.Clear();
        Console.WriteLine("Game was closed.");
        Console.CursorVisible = true;
    }

    private static void Init()
    {
        //console setup
        if (OperatingSystem.IsWindows())
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;
        }
        Console.CursorVisible = false;
        Console.Clear();
        StartGame.Start();
    }

    private static void CheckKeyboardInput()
    {
        if (Console.KeyAvailable)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Escape:
                    isRunning = false;
                    return;
            }
        }
    }
   
    private static void DelayGameLoop()
    {
        Thread.Sleep(1700);
    }
}