using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airport
{
    class Program
    {
        static IAirport airport = new Airport();
        static void Main(string[] args)
        {
            for (int i = 0, j = 0; i < 30; i++)
            {
                string s = new string(' ', i);
                Console.WriteLine("{0}__________________¶¶¶____________________________", s);
                Console.WriteLine("{0}___________________¶¶¶___________________________", s);
                Console.WriteLine("{0}__¶¶¶_______________¶¶¶¶_________________________", s);
                Console.WriteLine("{0}__¶¶¶¶_______________¶__¶________________________", s);
                Console.WriteLine("{0}__¶__¶¶¶_____________¶¶__¶¶______________________", s);
                Console.WriteLine("{0}__¶¶¶¶¶¶¶_____________¶¶___¶_____________________", s);
                Console.WriteLine("{0}__¶¶¶¶¶¶¶______________¶___¶¶____________________", s);
                Console.WriteLine("{0}__¶______¶_____________¶¶____¶___________________", s);
                Console.WriteLine("{0}_¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶___", s);
                Console.WriteLine("{0}_¶¶¶¶¶¶¶¶¶0¶0¶00¶0¶0¶¶0¶0¶00¶0¶0¶¶0¶0¶0¶¶00¶¶¶¶¶_", s);
                Console.WriteLine("{0}¶¶¶______________________¶¶_____¶_____________¶¶¶", s);
                Console.WriteLine("{0}___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_", s);
                Console.WriteLine("{0}_______________________¶_____¶___________________", s);
                Console.WriteLine("{0}______________________¶____¶¶____________________", s);
                Console.WriteLine("{0}_____________________¶_____¶_____________________", s);
                Console.WriteLine("{0}_____________________¶___¶¶______________________", s);
                Console.WriteLine("{0}____________________¶___¶________________________", s);
                Console.WriteLine("{0}___________________¶¶_¶¶_________________________", s);
                Console.WriteLine("{0}__________________¶¶_¶___________________________", s);
                Console.WriteLine("{0}_________________¶¶_¶¶___________________________", s);
                Console.WriteLine("{0}________________¶¶¶¶_____________________________", s);
                Thread.Sleep(90);
            }
            Console.Clear();
            Console.SetCursorPosition(10, 5);
            Menu();




        }
        static public void Menu()
        {
            Console.Clear();

            Console.WriteLine("                                  Welcome!");
            Console.WriteLine("                                ************   ");
            Console.WriteLine("       _____________________________________________________________");
            Console.WriteLine("      | Press 1. If you want to show Arrival Table                   |");
            Console.WriteLine("      | Press 2. If yoy want to show Departure Table                 |");
            Console.WriteLine("      | Press 3. If you want to show the flights pricelist           |");
            Console.WriteLine("      | Press 4. If you want to show the passengers list             |");
            Console.WriteLine("      | Press 5. If you want to change information                   |");
            Console.WriteLine("      | Press 6. If you want to search                               |");
            Console.WriteLine("      | Press ESC if you want to exit from the program               |");
            Console.WriteLine("       ______________________________________________________________");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    airport.PrintArrivals();
                    Console.ReadKey();
                    Menu();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    airport.PrintDeparture();
                    Console.ReadKey();
                    Menu();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    airport.PrintPriceClassInfo();
                    Console.ReadKey();
                    Menu();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.Clear();
                    airport.PrintPassengersInfo();
                    Console.ReadKey();
                    Menu();
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Console.Clear();
                    Menu2();
                    Console.ReadKey();

                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Console.Clear();
                    airport.Search();
                    Console.ReadKey();
                    Menu();
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    Console.ReadKey();
                    break;
            }
        }
        static public void Menu2()
        {

            Console.WriteLine("             Press 1. If you want to Create information");
            Console.WriteLine("            Press 2. If you want to Delete information");
            Console.WriteLine("           Press 3. If you want to Edit information");
            Console.WriteLine("          Press 4. If you want back to main menu");

            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    airport.Create();
                    Console.ReadKey();
                    Menu();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    airport.Del();
                    Console.ReadKey();
                    Menu();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    airport.Edit();
                    Console.ReadKey();
                    Menu();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.Clear();
                    Menu();
                    Console.ReadKey();
                    break;

            }


        }
    }
}
