using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkManager
{
    public class Rides
    {
        public Rides(string name, string description, int capacity, int scareLevel, double lengthOfRide, int ageReq)
        {
            Name = name;
            Description = description;  
            Capacity = capacity;    
            LengthOfRide = lengthOfRide;
            AgeReq = ageReq;
            ScareLevel = scareLevel;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int ScareLevel { get; set; }
        public double LengthOfRide { get; set; }
        public int AgeReq { get; set; }

        public static void CreateRide()
        {
            Console.WriteLine("Please enter the name of your new ride: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Please enter a brief description of {name}: ");
            string description = Console.ReadLine();
            Console.WriteLine($"Please enter the amount of passenger capacity for {name} (Please enter a number, E.g 1, 34, 10 etc.)");
            string passengerCapacity = Console.ReadLine();
            if (int.TryParse(passengerCapacity, out int number))
            {
                int passengerCapacityInt = number;
            }
            else
            {
                Console.WriteLine("Provided input was invalid. Please retry..");
                CreateRide();
            }
            Console.WriteLine($"Please enter the Scare Level for the ride: (On a scale from 1 - 10)");
            string fearFactor = Console.ReadLine();
            if (int.TryParse(fearFactor, out int fear))
            {
                if (fear <= 10 && fear >= 1)
                {
                    int fearLevel = fear;
                }
                else
                {
                    Console.WriteLine("Provided input was invalid. Please retry..");
                    CreateRide();
                }
            }
            else
            {
                Console.WriteLine("Provided input was invalid. Please retry..");
                CreateRide();
            }
            Console.WriteLine($"Please enter the length of time in minutes for the ride to complete: ");
            string length = Console.ReadLine();
            if (double.TryParse(length, out double lengths))
            {
                double lengthOfRide = lengths;
            }
            else
            {
                Console.WriteLine("Provided input was invalid. Please retry..");
                CreateRide();
            }
            Console.WriteLine($"Please enter the Minimum Age Requirement for {name}: ");
            string minimumAge = Console.ReadLine();
            if (int.TryParse(minimumAge, out int age))
            {
                int minimumAgeReqs = age;
            }
            else
            {
                Console.WriteLine("Provided input was invalid. Please retry..");
                CreateRide();
            }
            Console.WriteLine($"Great! So for this ride, It is named {name}, and it has a passenger capacity of {number}, and a Scare level of {fear}, and last for {lengths} minutes. Does this all look correct?");
            Console.WriteLine("Please enter 'yes' to add this ride to your park. To re-create the ride, please enter 'no': ");
            string yayOrNay = Console.ReadLine();
            if (yayOrNay == "yes")
            {
                Rides newRide = new Rides(name, description, number, fear, lengths, age);
                ThemePark.rides.Add(newRide);
                
            }
            else
            {
                CreateRide();
            }
            
            
        }
    }

}
