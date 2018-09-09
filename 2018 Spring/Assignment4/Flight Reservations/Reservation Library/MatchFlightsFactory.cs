using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Library
{
    public class MatchFlightsFactory
    {
        private DateTime Day;
        private String Orig;
        private String Dest;

        private List<Flight> Flights = Shared.Flight;
        private List<Flight> flightsOnDay = new List<Flight>();
        private List<Flight> Connectingflights = new List<Flight>();
        private List<ConnectingFlights> Matchedflights = new List<ConnectingFlights>();
        private FlightRequest chosen;
        ConnectingFlights con ;
        public MatchFlightsFactory(FlightRequest chosen)
        {
            this.chosen = chosen;
            this.Day = chosen.Date;
            this.Orig = chosen.SourceAirport;
            this.Dest = chosen.DestAirport;
            findConnections();

        }

        

        

        private void findConnections()
        {


            //get all flights for the day
            getFlights();

            foreach (Flight fl in flightsOnDay)
            {
              
                DateTime flArrival = fl.DateAndTime.AddHours(4);
                foreach (Flight confl in Connectingflights)
                {
                    if ( fl.DestAirport == confl.SourceAirport && flArrival < confl.DateAndTime)
                    {
                        con = new ConnectingFlights();
                        con.Add(fl);
                        con.Add(confl);
                        Matchedflights.Add(con);
                    }


                }

            }
        }

        public List<ConnectingFlights> getMatches()
        {
           
            return Matchedflights;
        }

        private void getFlights()
        {
            foreach (Flight fl in Shared.Flight)
            {
                //get all flights leave ori
                if (Day.DayOfYear == fl.DateAndTime.DayOfYear && fl.SourceAirport == Orig)
                {
                    
                    flightsOnDay.Add(fl);
                }
                //get all flights arriving dest
                if (Day.DayOfYear == fl.DateAndTime.DayOfYear && fl.DestAirport == Dest)
                {
                    Connectingflights.Add(fl);
                }

            }

        }


       

  

}


}
