using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Library
{
    public class FlightRequest
    {
        private List<Flight> Flights;  //Holds all the lights
        public FlightRequest()
        {
            Flights = Shared.Flight;

        }
    }
}
