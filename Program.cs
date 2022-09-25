namespace ThemeParkManager
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ThemeParkIntroduction();
            MainMenu();
            
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
            Console.WriteLine("1. Load existing Park");
            Console.WriteLine("2. Create a New Theme Park");
            MainMenuSelection();
        }
        private static void MainMenuSelection()
        {
            string userSelection = Console.ReadLine();
            switch (userSelection)
            {
                case "1":

                    break;
                case "2":
                    ThemePark.CreatePark();
                    break;
                default:
                    Console.WriteLine("Invaild entry, please try again.");
                    MainMenuSelection();
                    break;
            }
        }
    }
}