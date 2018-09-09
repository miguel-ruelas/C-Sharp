using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Library
{
    
    public class ConnectingFlights
    {
        List<Flight> Connections= new List<Flight>();
        private TimeSpan Duration = new TimeSpan(0,0,0);

        public ConnectingFlights()
        {

        }

        public ConnectingFlights(Flight orig)
        {
            Connections.Add(orig);

        }

        public void Add(Flight add)
        {
            if (Connections.Count == 0)
            {
                Connections.Add(add);
                


                return;
            }

            Flight test = Connections.Last();

            if (test.DestAirport == add.SourceAirport && test.DateAndTime.AddHours(4) < add.DateAndTime)
            {
                Connections.Add(add);
               

                return;

            }
        }

        private void setDuration()
        {
            if (Connections.Count > 1)
            {
                Flight first = Connections.ElementAt(0);
                Flight last = Connections.Last();
                Console.WriteLine("first:" + first.DateAndTime + " last:" + last.DateAndTime);
                Duration = last.DateAndTime.AddHours(4) - first.DateAndTime;
                Console.WriteLine("Duration:" + Duration + "Double:" + GetDuration);

            }
        }
        public override string ToString()
        {
            //add flights

            String str = "";
            foreach (Flight fl in Connections)
            {
                
                String flight = "";
                if (String.IsNullOrEmpty(str))
                {
                    flight = "[" + fl.FlightNumber + "]: " + fl.SourceAirport + "-" + fl.DestAirport +", ";
                }
                else
                {
                    flight = "and [" + fl.FlightNumber + "]: " + fl.SourceAirport + "-" + fl.DestAirport+", ";
                }

                str += flight;

                str += String.Format("({0:HH:mm}), ", fl.DateAndTime);
            }

            //add Duration
            setDuration();
            str += String.Format("Duration: {0:hh}:{0:mm}, ", Duration);

            //add cost
            str += "Cost: " + getCost().ToString();

            return str;
        }

        private double getCost()
        {
            double total = 0;
            foreach (Flight fl in Connections)
            {
                total += fl.Fare;
            }
            return total;
        }

        public Double GetDuration
        {
            get {
                double value = (Duration.Hours + Duration.Minutes / 100.0 + Duration.Seconds / 10000.0) * (Duration > TimeSpan.Zero ? 1 : -1);
                return value; }
           
        }

    }
}
