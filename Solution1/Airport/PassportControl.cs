using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class PassportControl
    {
        public static string Purpose { get; private set; }
        public static string HowLong { get; private set; }

        public static void Control(string country)
        {
            Console.WriteLine($"What's your purpose in {country}?");            
            Purpose = Console.ReadLine();

            Console.WriteLine("How long are you going to be there?");
            HowLong = Console.ReadLine();            
        }
        public static bool Debt()
        {
            Console.WriteLine("Do you have any debts?");
            string answer = "NO";
            if (answer.Equals(Console.ReadLine().ToUpper()))
                return false;
            else
            {
                Console.WriteLine("You can't fly to another country with more than $1000 in debt.");
                return true;
            }                
        }
        public static void Declare()
        {
            Console.WriteLine("Do you have goods to declare?");
            string answer = "NO";
            if (answer.Equals(Console.ReadLine().ToUpper()))
                return;
            else
            {
                Console.WriteLine("Fill out the Declaration.");               
            }
        }
    }
}
