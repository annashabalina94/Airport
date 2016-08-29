using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class ArrFlight : FlightBase
    {


        public ArrFlight(Random random)
        {
            Status = (Status)random.Next(3, 9);
        }
    }

    class DepFlight : FlightBase
    {
        public DepFlight(Random random)
        {
            Status = (Status)random.Next(1, 9);
        }
    }
    abstract class FlightBase
    {
        public List<Passengers> Passengersarr = new List<Passengers>();
        public Prices[] Pricesarr = new Prices[1];
        public string Flightnumber;
        public string Direction;
        public string Datetime;
        public string Terminal;
        public string Gate;
        public Status Status;
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
