using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Library
{
    /// <summary>
    /// contains a date and two airport codes, used when searching for matching flights. This class must be Public.
    /// </summary>
    public class FlightRequest
    {
        public String SourceAirport { get; set; }
        public String DestAirport { get; set; }
        public DateTime Date { get; set; }

        public FlightRequest(String sr, String dest, DateTime dt)
        {
            SourceAirport = sr;
            DestAirport = dest;
            Date = dt;

        }

        public override string ToString()
        {

            string str = String.Format("{0:MM/dd/yyyy}, flying from {1} to {2}",
                 Date, SourceAirport, DestAirport);
            //.ToString("MM-dd-yyyy")
            return str;
        }




    }
}
