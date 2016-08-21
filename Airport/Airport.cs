using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Airport:IAirport 
    {
      public   Airport()
        {
            Random random = new Random();
            
            var flight1 = new ArrFlight(random);
            flight1.flightnumber = "FS 4422";
            flight1.direction = "Abu-Dhabi";
            flight1.datetime = "14:22";
            flight1.terminal = "A";
            flight1.gate = "G1";
            var pasan1 = new Passengers();
            pasan1.name = "Ali";
            pasan1.secondname = "Baba";
            pasan1.pasport = "MT 111 111";
            pasan1.dateofbirthday = "08.07.1995";
            pasan1.nationality = Nationality.Arab;
            pasan1.sex = Sex.Male;
            flight1.passengersarr.Add(pasan1);
            var price1 = new Prices();
            price1.classprice = Classprice.Bissnes;
            flight1.pricesarr[0] = price1;
            flights.Add(flight1);

            var flight2 = new ArrFlight(random);
            flight2.flightnumber = "MN 7564";
            flight2.direction = "Paris";
            flight2.datetime = "13:00";
            flight2.terminal = "B";
            flight2.gate = "G2";
            var pasan2 = new Passengers();
            pasan2.name = "Ivan";
            pasan2.secondname = "Ivanov";
            pasan2.pasport = "MT 111 112";
            pasan2.dateofbirthday = "08.07.1993";
            pasan2.nationality = Nationality.French;
            pasan2.sex = Sex.Male;
            flight2.passengersarr.Add(pasan2);
            var price2 = new Prices();
            price2.classprice = Classprice.Economy;
            flight2.pricesarr[0] = price2;
            flights.Add(flight2);

            var flight3 = new ArrFlight(random);
            flight3.flightnumber = "ST 764";
            flight3.direction = "Odessa";
            flight3.datetime = "7:40";
            flight3.terminal = "B";
            flight3.gate = "G3";
            var pasan3 = new Passengers();
            pasan3.name = "Moisha";
            pasan3.secondname = "Snipperson";
            pasan3.pasport = "MT 111 113";
            pasan3.dateofbirthday = "08.07.1992";
            pasan3.nationality = Nationality.Jew;
            pasan3.sex = Sex.Male;
            flight3.passengersarr.Add(pasan3);
            var price3 = new Prices();
            price3.classprice = Classprice.Economy;
            flight3.pricesarr[0] = price3;
            flights.Add(flight3);

            var flight4 = new DepFlight(random);
            flight4.flightnumber = "DC 678";
            flight4.direction = "Kiev";
            flight4.datetime = "17:15";
            flight4.terminal = "A";
            flight4.gate = "G1";
            var pasan4 = new Passengers();
            pasan4.name = "Anna";
            pasan4.secondname = "Shabalina";
            pasan4.pasport = "MT 111 114";
            pasan4.dateofbirthday = "08.07.1994";
            pasan4.nationality = Nationality.Ukranian;
            pasan4.sex = Sex.Female;
            flight4.passengersarr.Add(pasan4);
            var price4 = new Prices();
            price4.classprice = Classprice.Bissnes;
            flight4.pricesarr[0] = price4;
            flights.Add(flight4);

            var flight5 = new DepFlight(random);
            flight5.flightnumber = "QS 6789";
            flight5.direction = "Toronto";
            flight5.datetime = "11:10";
            flight5.terminal = "B";
            flight5.gate = "G2";
            var pasan5 = new Passengers();
            pasan5.name = "Petr";
            pasan5.secondname = "Petrov";
            pasan5.pasport = "MT 111 115";
            pasan5.dateofbirthday = "08.07.1990";
            pasan5.nationality = Nationality.Canadian;
            pasan5.sex = Sex.Male;
            flight5.passengersarr.Add(pasan5);
            var price5 = new Prices();
            price5.classprice = Classprice.Bissnes;
            flight5.pricesarr[0] = price5;
            flights.Add(flight5);
         }

        List<FlightBase> flights = new List<FlightBase>();
      

        public void PrintArrivals()
        {

            Console.WriteLine("Arrival: ");
            Console.WriteLine(" _____________________________________________________________________");
            Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|");
            Console.WriteLine(" _____________________________________________________________________");

            for (int i = 0; i < flights.Count; i = i + 1)
                if (flights[i] is ArrFlight)
                {
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].flightnumber, flights[i].direction, flights[i].datetime, flights[i].status, flights[i].terminal, flights[i].gate);
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
                if (flights[i] is DepFlight)
                {
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].flightnumber, flights[i].direction, flights[i].datetime, flights[i].status, flights[i].terminal, flights[i].gate);
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
                int rand = random.Next(1000, 5000);
                Console.WriteLine("|{0,6}    |{1,10} |{2,3}$ |",flights[i].direction, flights[i].pricesarr[0].classprice,rand);
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
                Console.WriteLine("|{0,7} |{1,5} |{2,11} |{3,10}  |{4,8}|{5,4}|{6,3} |{7,5}|", flights[i].flightnumber, flights[i].passengersarr[0].name, flights[i].passengersarr[0].secondname, flights[i].passengersarr[0].nationality, flights[i].passengersarr[0].pasport, flights[i].passengersarr[0].dateofbirthday, flights[i].passengersarr[0].sex, flights[i].pricesarr[0].classprice);
            Console.WriteLine(" _____________________________________________________________________________");
            }
        }


        public void Create()
        {
            Console.WriteLine("What you wan to create?\nArrival Flights - 1\nDeparture Flights - 2\nNew passenger - 3");

            FlightBase cr = null;
          ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();
            if (key.Key==ConsoleKey.D1)
            { cr = new ArrFlight(new Random()); }
            else { cr = new DepFlight(new Random()); }
          
                    Console.Clear();
                    Console.Write("Input flight number: ");
                    cr.flightnumber = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Input City: ");
                    cr.direction = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Input time hh:mm ~ ");
                    cr.datetime = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Input terminal: ");
                    cr.terminal = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Input gate: ");
                    cr.terminal = Console.ReadLine();
                    Console.ReadKey();
      
            flights.Add(cr);

        }

        public void Del()
        {
            Console.WriteLine("Input flight number wich you want to delete");
            string line = Console.ReadLine();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].flightnumber.Contains(line))
                    flights.RemoveAt(i);
                
            }
            Console.WriteLine("Press ESC to exit to the main menu");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    Console.Clear();
                  
                    //Menu();
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
                if (flights[i].flightnumber.Contains(line) || flights[i].direction.Contains(line))
                {
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|");
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].flightnumber, flights[i].direction, flights[i].datetime, flights[i].status, flights[i].terminal, flights[i].gate);
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("If you want to edit flight number - 1\ndirection - 2\ndate and time - 3\nterminal - 4\n gate - 5");
                    ConsoleKeyInfo key = new ConsoleKeyInfo();
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Clear();
                            flights[i].flightnumber = Console.ReadLine();
                            break;

                        case ConsoleKey.D2:
                            Console.Clear();
                            flights[i].direction = Console.ReadLine();
                            break;

                        case ConsoleKey.D3:
                            Console.Clear();
                            flights[i].datetime = Console.ReadLine();
                            break;

                        case ConsoleKey.D4:
                            Console.Clear();
                            flights[i].terminal = Console.ReadLine();
                            break;

                        case ConsoleKey.D5:
                            Console.Clear();
                            flights[i].gate = Console.ReadLine();
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
                if (flights[i].flightnumber.Contains(line) || flights[i].direction.Contains(line)) 
                {
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|");
                    Console.WriteLine(" _____________________________________________________________________");
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].flightnumber, flights[i].direction, flights[i].datetime, flights[i].status, flights[i].terminal, flights[i].gate);
                    Console.WriteLine(" _____________________________________________________________________");
                } 
                for (int j = 0; j < flights[i].passengersarr.Count; j++)
                {
                    if (flights[i].passengersarr[j].name.Contains(line) || flights[i].passengersarr[j].secondname.Contains(line) || flights[i].passengersarr[j].pasport.Contains(line))
                    {
            Console.WriteLine(" ______________________________________________________________________________");
            Console.WriteLine("| Number | Name | Second Name | Nationality | Pasport |    DB    | Sex | Class |");
            Console.WriteLine("|________|______|_____________|_____________|_________|__________|_____|_______|");
            Console.WriteLine("|{0,7} |{1,5} |{2,11} |{3,10}  |{4,8}|{5,4}|{6,3} |{7,5}|", flights[i].flightnumber, flights[i].passengersarr[0].name, flights[i].passengersarr[0].secondname, flights[i].passengersarr[0].nationality, flights[i].passengersarr[0].pasport, flights[i].passengersarr[0].dateofbirthday, flights[i].passengersarr[0].sex, flights[i].pricesarr[0].classprice);
            Console.WriteLine(" _____________________________________________________________________________");   
                    }
                    }
            }

        }
    }
}
