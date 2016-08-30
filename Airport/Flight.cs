using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class ArrFlight : FlightBase
    {


        public  ArrFlight(Random random, Classprice Bissnes, Classprice Economy)
        {
            Status = (Status)random.Next(3, 9);
            Classprice = (Classprice)random.Next(1, 3);
            if (Classprice == Classprice.Bissnes)
            {
               Price = 2000;
            }
            else
            {
               Price = 1000;
            }
        }

    }

    class DepFlight : FlightBase
    {
        public  DepFlight(Random random, Classprice Bissnesm, Classprice Economy)
        {
            Status = (Status)random.Next(1, 9);
            Classprice = (Classprice)random.Next(1, 3);

            if (Classprice == Classprice.Bissnes)
            {
               Price = 2000;
            }
            else
            {
            Price = 1000;
            }
        }
    }


    abstract class FlightBase
    {
        public List<Passengers> Passengersarr = new List<Passengers>();
        public int Price;
        public Classprice Classprice;
        public string Flightnumber;
        public string Direction;
        public string Datetime;
        public string Terminal;
        public string Gate;
        public Status Status;
    }

    enum Classprice
    {
        Unknown = 0,
        Economy = 1,
        Bissnes = 2,
    }
    enum Status
    {
        Unknown = 0,
        CheckIn = 1,
        GateClosed = 2,
        Arrived = 3,
        DepartedAt = 4,
        Canceled = 5,
        ExpectedAt = 6,
        Delayed = 7,
        InFlight = 8
    }
}
