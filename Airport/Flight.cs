using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class ArrFlight:FlightBase 
    {
        
    
        public ArrFlight(Random random)
        {
            status = (Status)random.Next(3, 9);
        }
    }
    
    class DepFlight:FlightBase 
    {   
        public DepFlight(Random random)
        {
            status = (Status)random.Next(1, 9);
        }
    }
    abstract class  FlightBase 
    {
        public List<Passengers> passengersarr = new List<Passengers>();
        public Prices[] pricesarr = new Prices[1];
        public string flightnumber;
        public string direction;
        public string datetime;
        public string terminal;
        public string gate;
        public Status status;
    }
    enum Status
    {
    unknown=0,
    checkIn=1,
    gateClosed=2,
    arrived=3,
    departedAt=4,
    canceled=5, 
    expectedAt=6, 
    delayed=7, 
    inFlight=8
    }
}
