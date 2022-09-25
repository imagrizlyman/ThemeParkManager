using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkManager
{
    public class ThemePark
    {
        
        public ThemePark(string name, string description)
        {
            Name = name;
            Description = description;  
        }
        
        public static List<ThemePark> ThemeParks = new List<ThemePark>();
        public static List<Rides> rides = new List<Rides>();
        public string Name { get; set; }
        public string Description { get; set; }
        
        public static void CreatePark()
        {
            string name = Console.ReadLine();
            string description = Console.ReadLine();   
            ThemePark newPark = new ThemePark(name, description);
            ThemeParks.Add(newPark);
        }
        
    }

}
