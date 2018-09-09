using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///This program was created as a coursework assignment by
///@Author   : Miguel A. Ruelas Jacobo
///For:
///Course    : COP 4814 Component Based Software Development U01
///Professor : Kip Irvine
///Assignment:Assignment 1
///Due Date : 02/11/2018
/// </summary>
namespace Airports
{
    /// <summary>
    /// Airport is a Class that holds the flight times, and location  of an airport. It also contains a list of 
    /// all known airports.
    /// </summary>
    public class Airport
    {
        //List of all known airports.
        private static List<String> AirportList = new List<string> { "DEN", "LAX", "MIA", "SEA" };

        //List of times flights go out each day
        private List<TimeSpan> FlightSchedules = new List<TimeSpan>();

        /// <summary>
        /// Airport Constructor receives an airport location upon creation. It checks the location against 
        /// the known airports list. If an invalid location is received then it sets its location to "!!!".
        /// Airport objects with a Location of "!!!" are invalid and should be discarded.
        /// </summary>
        /// <param name="loc">String containing the uppercase three digit airport code</param>
        public Airport(string loc)
        {
            
            Boolean found = false; //true if location recieved is found, otherwise false

            //Search for loc in each airport in list
            foreach (String airport in AirportList)
            {
                //Airport in list is uppercase
                if (loc.ToUpper() == airport)
                {
                    //Set the location
                    found = true; 
                    this.Location = airport;
                }
            }
            if (found == false)
            {
                //Set the location to invalid 
                this.Location = "!!!";
            }

        }
        /// <summary>
        /// Location property returns the location of this airport
        /// </summary>
        public String Location { get; set; }

        /// <summary>
        /// GetAirports returns a list of all known airports.
        /// </summary>
        /// <returns></returns>
        public static List<Airport> GetAirports()
        {
            //Create a copy of the list
            List<Airport> ListAirports = new List<Airport>();
            foreach (String Airport in AirportList)
            {
                Airport tempAir = new Airport(Airport);
                ListAirports.Add(tempAir);
            }
            return ListAirports; //return the copy.
        }

        /// <summary>
        /// FlightSchedule method gets and sets the daily flight times
        /// for each day in this airport.
        /// </summary>
        public List<TimeSpan> FlightSchedule
        {
            get { return FlightSchedules; }
            set { FlightSchedules = value; }
        }

    }
}
