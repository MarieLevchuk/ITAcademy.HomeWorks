using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class SecurityCheck
    {
        public static int AskAboutAmount()
        {
            Console.WriteLine("How many bags have you got?");
            return int.Parse(Console.ReadLine());
        }
        public static void AskAboutSharpItem()
        {
            Console.WriteLine("Have you got any sharp item?");

            string answer = "YES";
            string permission = "Put your keys, watches, coins and gadgets in the container and pass through the metal detector frame.";
            if (answer.Equals(Console.ReadLine().ToUpper()))
                Console.WriteLine("Lay them all out." + permission);
            else
                Console.WriteLine("OK."+permission);                        
        }      
    }
}
