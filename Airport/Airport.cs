using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Airport : IAirport
    {
        public Airport()
        {
            Random random = new Random();


            var flight1 = new FlightBase(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight1.FlightStatus = FlightStatus.Arrival;
            flight1.Flightnumber = "FS 4422";
            flight1.Direction = "Abu-Dhabi";
            flight1.Datetime = "14:22";
            flight1.Terminal = "A";
            flight1.Gate = "G1";
            var pasan1 = new Passengers();
            pasan1.Name = "Ali";
            pasan1.Secondname = "Baba";
            pasan1.Pasport = "MT 111 111";
            pasan1.Dateofbirthday = "08.07.1995";
            pasan1.Nationality = Nationality.Arab;
            pasan1.Sex = Sex.Male;
            flight1.Passengersarr.Add(pasan1);
           // flight1.Classprice = Classprice.Bissnes;
            flights.Add(flight1);

            var flight2 = new FlightBase(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight2.FlightStatus = FlightStatus.Arrival;
            flight2.Flightnumber = "MN 7564";
            flight2.Direction = "Paris";
            flight2.Datetime = "13:00";
            flight2.Terminal = "B";
            flight2.Gate = "G2";
            var pasan2 = new Passengers();
            pasan2.Name = "Ivan";
            pasan2.Secondname = "Ivanov";
            pasan2.Pasport = "MT 111 112";
            pasan2.Dateofbirthday = "08.07.1993";
            pasan2.Nationality = Nationality.French;
            pasan2.Sex = Sex.Male;
            flight2.Passengersarr.Add(pasan2);
            //flight2.Classprice = Classprice.Economy;
            flights.Add(flight2);

            var flight3 = new FlightBase(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight3.FlightStatus = FlightStatus.Departure;
            flight3.Flightnumber = "ST 764";
            flight3.Direction = "Odessa";
            flight3.Datetime = "7:40";
            flight3.Terminal = "B";
            flight3.Gate = "G3";
            var pasan3 = new Passengers();
            pasan3.Name = "Moisha";
            pasan3.Secondname = "Snipperson";
            pasan3.Pasport = "MT 111 113";
            pasan3.Dateofbirthday = "08.07.1992";
            pasan3.Nationality = Nationality.Jew;
            pasan3.Sex = Sex.Male;
            flight3.Passengersarr.Add(pasan3);
            //flight3.Classprice = Classprice.Economy;
            flights.Add(flight3);

            var flight4 = new FlightBase(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight4.FlightStatus = FlightStatus.Departure;
            flight4.Flightnumber = "DC 678";
            flight4.Direction = "Kiev";
            flight4.Datetime = "17:15";
            flight4.Terminal = "A";
            flight4.Gate = "G1";
            var pasan4 = new Passengers();
            pasan4.Name = "Anna";
            pasan4.Secondname = "Shabalina";
            pasan4.Pasport = "MT 111 114";
            pasan4.Dateofbirthday = "08.07.1994";
            pasan4.Nationality = Nationality.Ukranian;
            pasan4.Sex = Sex.Female;
            flight4.Passengersarr.Add(pasan4);
            //flight4.Classprice = Classprice.Bissnes;
            flights.Add(flight4);

            var flight5 = new FlightBase(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight5.FlightStatus = FlightStatus.Arrival;
            flight5.Flightnumber = "QS 6789";
            flight5.Direction = "Toronto";
            flight5.Datetime = "11:10";
            flight5.Terminal = "B";
            flight5.Gate = "G2";
            var pasan5 = new Passengers();
            pasan5.Name = "Petr";
            pasan5.Secondname = "Petrov";
            pasan5.Pasport = "MT 111 115";
            pasan5.Dateofbirthday = "08.07.1990";
            pasan5.Nationality = Nationality.Canadian;
            pasan5.Sex = Sex.Male;
            flight5.Passengersarr.Add(pasan5);
            //flight5.Classprice = Classprice.Bissnes;
            flights.Add(flight5);
        }

        List<FlightBase> flights = new List<FlightBase>();


        public void PrintArrivals()
        {

            Console.WriteLine("Arrival: ");
            Console.WriteLine(" _____________________________________________________________________");
            Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|");
            Console.WriteLine(" _____________________________________________________________________");

            for (int i = 0; i < flights.Count; i++)
                //if (flights[i] is ArrFlight)
                if (flights[i].FlightStatus == FlightStatus.Arrival)
                {
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime, flights[i].Status, flights[i].Terminal, flights[i].Gate);
                    Console.WriteLine(" _____________________________________________________________________");
                }
        }

        public void PrintDeparture()
        {
            Console.WriteLine("Departure: ");
            Console.WriteLine(" _____________________________________________________________________");
            Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|");
            Console.WriteLine(" _____________________________________________________________________");

            for (int i = 0; i < flights.Count; i = i + 1)
                //if (flights[i] is DepFlight)
                if (flights[i].FlightStatus == FlightStatus.Departure)
                {
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime, flights[i].Status, flights[i].Terminal, flights[i].Gate);
                    Console.WriteLine(" _____________________________________________________________________");
                }
        }
        public void PrintPriceClassInfo()
        {
            Random random = new Random();

            Console.WriteLine("Pricelist:");
            Console.WriteLine(" ______________________________");
            Console.WriteLine("|  Direction  |  Class | Price |");
            Console.WriteLine("|_____________|________|_______|");
            for (int i = 0; i < flights.Count; i++)
            {
                //int rand = random.Next(1000, 5000);//!!!!!!!
                Console.WriteLine("|{0,6}    |{1,10} |{2,3}$ |", flights[i].Direction, flights[i].Classprice, flights[i].Price);
                Console.WriteLine("|_____________|_______|_______|");

            }
        }

        public void PrintPassengersInfo()
        {
            Console.WriteLine(" ______________________________________________________________________________");
            Console.WriteLine("| Number | Name | Second Name | Nationality | Pasport |    DB    | Sex | Class |");
            Console.WriteLine("|________|______|_____________|_____________|_________|__________|_____|_______|");

            for (int i = 0; i < flights.Count; i++)
            {
                Console.WriteLine("|{0,7} |{1,5} |{2,11} |{3,10}  |{4,8}|{5,4}|{6,3} |{7,5}|", flights[i].Flightnumber, flights[i].Passengersarr[0].Name, flights[i].Passengersarr[0].Secondname, flights[i].Passengersarr[0].Nationality, flights[i].Passengersarr[0].Pasport, flights[i].Passengersarr[0].Dateofbirthday, flights[i].Passengersarr[0].Sex, flights[i].Classprice);
                Console.WriteLine(" _____________________________________________________________________________");
            }
        }


        public void Create()
        {
            Console.WriteLine("What you wan to create?\nArrival Flights - 1\nDeparture Flights - 2");

            FlightBase cr = null;
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
            {
                cr = new FlightBase(new Random(), Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);//??
            }
            else
            {
                cr = new FlightBase(new Random(), Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);//??
            }

            Console.Clear();
            Console.Write("Input flight number: ");
            cr.Flightnumber = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Input City: ");
            cr.Direction = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Input time hh:mm ~ ");
            cr.Datetime = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Input terminal: ");
            cr.Terminal = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Input gate: ");
            cr.Gate = Console.ReadLine();
            Console.ReadKey();

            flights.Add(cr);

        }

        public void Del()
        {
            Console.WriteLine("Input flight number wich you want to delete");
            string line = Console.ReadLine();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].Flightnumber.Contains(line))
                    flights.RemoveAt(i);

            }
            Console.WriteLine("Press ESC to exit to the main menu");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    Console.Clear();
                    break;
            }
        }
        public void Edit()
        {
            //passengers list. It should reflect the information about the flight number,  passenger first name, second name,
            //nationality, passport, date of birthday, sex, class (business, economy)
            //editing of  this information

            Console.WriteLine("Input flight number, direction information wich you want to edit");
            string line = Console.ReadLine();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].Flightnumber.Contains(line) || flights[i].Direction.Contains(line))
                {
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|");
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime, flights[i].Status, flights[i].Terminal, flights[i].Gate);
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("If you want to edit flight number - 1\ndirection - 2\ndate and time - 3\nterminal - 4\n gate - 5");
                    ConsoleKeyInfo key = new ConsoleKeyInfo();
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Console.Clear();
                            flights[i].Flightnumber = Console.ReadLine();
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Console.Clear();
                            flights[i].Direction = Console.ReadLine();
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Console.Clear();
                            flights[i].Datetime = Console.ReadLine();
                            break;

                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            Console.Clear();
                            flights[i].Terminal = Console.ReadLine();
                            break;

                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            Console.Clear();
                            flights[i].Gate = Console.ReadLine();
                            break;


                    }


                }


            }
        }
        public void Search()
        {
            //search by the flight number, price, first and second name, passport, arrival (departure) port of and information output in the specified format

            Console.WriteLine("Input flight number, price, first and second name, passport, direction information wich you want to search");
            string line = Console.ReadLine();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].Flightnumber.Contains(line) || flights[i].Direction.Contains(line))
                {
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|");
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime, flights[i].Status, flights[i].Terminal, flights[i].Gate);
                    Console.WriteLine(" _____________________________________________________________________");
                }
                for (int j = 0; j < flights[i].Passengersarr.Count; j++)
                {
                    if (flights[i].Passengersarr[j].Name.Contains(line) || flights[i].Passengersarr[j].Secondname.Contains(line) || flights[i].Passengersarr[j].Pasport.Contains(line))
                    {
                        Console.WriteLine(" ______________________________________________________________________________");
                        Console.WriteLine("| Number | Name | Second Name | Nationality | Pasport |    DB    | Sex | Class |");
                        Console.WriteLine("|________|______|_____________|_____________|_________|__________|_____|_______|");
                        Console.WriteLine("|{0,7} |{1,5} |{2,11} |{3,10}  |{4,8}|{5,4}|{6,3} |{7,5}|", flights[i].Flightnumber, flights[i].Passengersarr[0].Name, flights[i].Passengersarr[0].Secondname, flights[i].Passengersarr[0].Nationality, flights[i].Passengersarr[0].Pasport, flights[i].Passengersarr[0].Dateofbirthday, flights[i].Passengersarr[0].Sex, flights[i].Classprice);
                        Console.WriteLine(" _____________________________________________________________________________");
                    }
                }
            }

        }
    }
}
