using System;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CheckIn.Greeting();

            Console.WriteLine("Your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your patronymic: ");
            string patronymic = Console.ReadLine();

            Passenger passenger = new Passenger(surname, name, patronymic);
            Passport passport = new Passport();
            BoardingCard boardingCard;

            Console.WriteLine(CheckIn.RequestDocuments(passenger.Name, passenger.Patronymic));
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Ticket ticket = new Ticket();
                    boardingCard = new BoardingCard();
                    break;
                case 2:
                    int seat = CheckIn.AskAboutSeat();
                    string country = CheckIn.AskAboutCountryOfConsignment();
                    boardingCard = new BoardingCard(country, seat);
                    break;
                default:
                    boardingCard = new BoardingCard();
                    break;
            }
            Console.WriteLine($"\nHere's your boarding card:\nCountry of Consignment:{boardingCard.CountryOfConsignment}\nFlight number: {boardingCard.FlightNuber}\nGate:{boardingCard.Gate}\nSeat:{boardingCard.Seat}");
            
            Console.WriteLine("Go to the security check.");            
            Luggage luggage = new Luggage(SecurityCheck.AskAboutAmount());
            SecurityCheck.AskAboutSharpItem();
            LuggageTag luggageTag = new LuggageTag();
            Console.WriteLine($"\nHere's your luggage tag:\nAmount: {luggage.Amount}\nNumber: {luggageTag.DocumentNumber}");

            Console.WriteLine("Go to the passport control.");
            PassportControl.Control(boardingCard.CountryOfConsignment);
            if (!PassportControl.Debt())
            {
                PassportControl.Declare();
                Console.WriteLine("\nEnjoy your flight!.");
            }
            else
                Console.WriteLine("You can't fly abroad.");            
        }
    }
}
