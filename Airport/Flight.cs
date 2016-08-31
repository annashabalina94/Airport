﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    //class ArrFlight : FlightBase//убрать наследование
    //{


    //    public  ArrFlight(Random random, Classprice Bissnes, Classprice Economy)
    //    {
    //        Status = (Status)random.Next(3, 9);
    //        Classprice = (Classprice)random.Next(1, 3);
    //        if (Classprice == Classprice.Bissnes)
    //        {
    //           Price = 2000;
    //        }
    //        else
    //        {
    //           Price = 1000;
    //        }
    //    }

    //}

    //class DepFlight : FlightBase
    //{
    //    public  DepFlight(Random random, Classprice Bissnesm, Classprice Economy)
    //    {
    //        Status = (Status)random.Next(1, 9);
    //        Classprice = (Classprice)random.Next(1, 3);

    //        if (Classprice == Classprice.Bissnes)
    //        {
    //           Price = 2000;
    //        }
    //        else
    //        {
    //        Price = 1000;
    //        }
    //    }
    //}


   // abstract 
        class FlightBase
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
        public FlightStatus FlightStatus;

        public FlightBase(Random random, Classprice Bissnesm, Classprice Economy, FlightStatus Arrival, FlightStatus Departure)
        {
            //FlightStatus =(FlightStatus)random.Next(1, 3);
            Classprice = (Classprice)random.Next(1, 3);
            if(FlightStatus==FlightStatus.Arrival)
            {
                Status = (Status)random.Next(3, 9);
            }
            else
            {
                Status = (Status)random.Next(1, 9);
            }
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

    enum FlightStatus
    {
        Unknown = 0,
        Arrival = 1,
        Departure = 2
    }
    enum Classprice
    {
        Unknown = 0,
        Economy = 1,
        Bissnes = 2
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
