using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class CheckIn
    {
        static string airport = "Tegel";
        public static void Greeting()
        {
            StringBuilder message = new StringBuilder($"Welcome to the airport \"{airport}\"!\nPlease introduce yourself:");
            TimeSpan time = DateTime.Now.TimeOfDay;
            int hours = time.Hours;

            if (hours >= 6 && hours < 12)
                message.Insert(0, "Good morning! ");
            if (hours >= 12 && hours < 17)
                 message.Insert(0, "Good day! ");
            if (hours >= 17 && hours < 23)
                message.Insert(0, "Good evening! ");
            else
                message.Insert(0, "Good evening! ");

            Console.WriteLine(message.ToString());
        }
        public static string RequestDocuments(string name, string patronymic)
        {
            return $"{name} {patronymic} can I have your passport and ticket, please?\nEnter \"1\" if you have got the ticket.\nEnter \"2\" if you haven't got a ticket.";
        }
        public static int AskAboutSeat()
        {
            int s;
            Console.WriteLine("Would you like a window (enter 1), an aisle (enter 2) or a middle (enter 3) seat?");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    s = 10;
                    break;
                case 2:
                    s = 20;
                    break;
                case 3:
                    s = 30;
                    break;
                default:
                    s = 40;
                    break;
            }
            return s;
        }
        public static string AskAboutCountryOfConsignment()
        {
            Console.WriteLine("What country are you flying to?");
            return Console.ReadLine();
        }        
    }
}
