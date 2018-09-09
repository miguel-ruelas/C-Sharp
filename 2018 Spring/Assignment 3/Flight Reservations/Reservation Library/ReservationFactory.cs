using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// all methods related to searching for flights, including the creation of the FlightRequest objects. 
/// This class will expand in future assignments, as we begin to schedule reservations. 
/// This class must be Public, and it does not have the same structure as the Flight class. 
/// </summary>
namespace Reservation_Library
{
    public class ReservationFactory
    {
        private Random rand = new Random();
        private List<FlightRequest> Requests = new List<FlightRequest>();
        private List<Flight> flightsFound = new List<Flight>();
        private String filepath = @"..\..\..\Flight Reservations\matchingflights.xml";
        public String FileName
        {
            get { return Path.GetFileName(filepath); }
        }
            
        public void findFlights(int index,String version)
        {
            if (index < 0)
            {
                return;
            }
            else
            {
                FlightRequest temp = Requests.ElementAt(index);
                flightsFound.Clear();

                foreach (Flight fl in Shared.Flight)
                {
                    if (temp.Date == fl.DateAndTime.Date)
                        if (temp.DestAirport == fl.DestAirport)
                            if (temp.SourceAirport == fl.SourceAirport)
                                flightsFound.Add(fl);
                }
                Serialize(version);
            }

            

        }
        /// <summary>
        /// The requests should include all possible airport combinations, on a variety of dates.
        /// </summary>
        public void CreateFlightRequest()
        {
            Requests.Clear();
            int count = 0;
            while(count<20)
            {
                foreach (Airport airp in Shared.Airports())
                {
                    
                    //Loop through each airportin the Airports list and create an airport object which will hold the destination airport.
                    foreach (Airport arp2 in Shared.Airports())
                    {
                        string test1 = airp.Location;  //Get the source airport name
                        string test2 = arp2.Location;  //Get the Destination airport name

                        if (test1 != test2) //do not create flight request for same airport
                        {
                            if (count == 20)
                                break;
                            //Get the price for the flight using the source(test1), destination(test2) airports and the time of day(tme)
                            FlightRequest temp = new FlightRequest(test1, test2, GetRandDate());
                            Requests.Add(temp);
                            count++;
                        }

                    }

                }
                
            
            }
        }

        private DateTime GetRandDate()
        {
            int days = rand.Next(0, 30);
            DateTime randDate = Shared.StartDate().AddDays(days);
            return randDate;
        }

        public List<FlightRequest> GetRequests()
        {
            return Requests;
        }

        public Boolean Serialize(String version)
        {
            return Shared.Serialize(flightsFound, filepath, version);

        }



    }
}
