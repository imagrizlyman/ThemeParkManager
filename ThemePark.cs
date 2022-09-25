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
        public string Name { get; set; }
        public string Description { get; set; }
        
        List<Rides> rides = new List<Rides>();
        
    }
}
