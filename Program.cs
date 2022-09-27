namespace ThemeParkManager
{
    public class Program
    {
        public static bool appIsRunning = true;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                ThemeParkIntroduction();
                MainMenu();
            }
            while (appIsRunning);
        }
        private static void ThemeParkIntroduction()
        {
            Console.WriteLine("||======================================================================================||");
            Console.WriteLine("|| $$       $$  $$$$$$$$$$  $$        $$$$$$    $$$$$$       $$     $$       $$$$$$$$$$ ||");
            Console.WriteLine("|| $$  $$   $$  $$          $$       $$    $$  $$    $$     $$$$   $$$$      $$         ||");
            Console.WriteLine("|| $$ $$ $$ $$  $$$$$$$$$$  $$       $$        $$    $$    $$   $$$$  $$     $$$$$$$$$$ ||");
            Console.WriteLine("|| $$$$   $$$$  $$          $$       $$    $$  $$    $$   $$     $$    $$    $$         ||");
            Console.WriteLine("|| $$       $$  $$$$$$$$$$  $$$$$$$$  $$$$$$    $$$$$$   $$             $$   $$$$$$$$$$ ||");
            Console.WriteLine("||======================================================================================||");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("              Welcome to the one stop shop for all things Theme Park!                     ");
            Console.WriteLine();
            Console.WriteLine("Within this application, we provide you the tools you need to create your very own virtual");
            Console.WriteLine("theme park simulation.");
            Console.WriteLine();
            Console.WriteLine("                           We hope you have fun!");
        }
        private static void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Where would you like to begin?");  
            Console.WriteLine("Please enter your selection (E.g. 1, 2, 3 etc.) Then press your enter key.");
            Console.WriteLine();
            Console.WriteLine("1. Create a New Theme Park");
            Console.WriteLine("2. Load an Existing Park");
            Console.WriteLine("3. Exit the application");
            MainMenuSelection();
        }
        private static void MainMenuSelection()
        {
            string userSelection = Console.ReadLine();
            switch (userSelection)
            {
                case "1":
                    ThemePark.CreatePark();
                    break;
                case "2":
                    
                    break;
                case "3":
                    appIsRunning = false;
                    break;
                default:
                    Console.WriteLine("Invaild entry, please try again.");
                    MainMenuSelection();
                    break;
            }
        }
    }
}