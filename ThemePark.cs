using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkManager
{
    public class ThemePark
    {
        
        public ThemePark(string username, string password, string name, string description)
        {
            Name = name;
            Description = description;
            Username = username;
            Password = password;
        }
        
        public static List<ThemePark> themeParks = new List<ThemePark>();
        public static List<Rides> rides = new List<Rides>();
        public string Name { get; set; }
        public string Description { get; set; }
        public string Username { get; }
        public string Password { get; }
        public List<Rides> RidesList { get; set; }
        public static void CreatePark()
        {
            Console.WriteLine("Please enter the name of your new park: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Please give a brief description of {name}: "); 
            string description = Console.ReadLine();
            Console.WriteLine("Please create a username for your Manager account: ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter a password for your manager account: ");
            string password = Console.ReadLine();
            Console.WriteLine($"Thank you, Would you like to create rides for {name} now or add some later? (E.g 'yes' or 'no')");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Rides.CreateRide();
            }
            ThemePark newPark = new ThemePark(username, password, name, description);
            themeParks.Add(newPark);
        }
        
    }

}
