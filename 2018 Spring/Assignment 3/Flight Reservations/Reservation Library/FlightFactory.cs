using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


/// <summary>
///This program was created as a coursework assignment by
///@Author   : Miguel A. Ruelas Jacobo
///For:
///Course    : COP 4814 Component Based Software Development U01
///Professor : Kip Irvine
///Assignment:Assignment 1
///Due Date : 02/11/2018
/// </summary>
namespace Reservation_Library
{
    /// <summary>
    /// FlightFactory class contains all the methods for creating a list of Flight objects and
    /// sending/retriving them to and from an XML file.
    /// <list type="bullet">
    /// <item>
    /// <term>CreateFlights</term>
    /// <description>Method that creates a list of flights</description>
    /// </item>
    /// <item>
    /// <term>FilePath</term>
    /// <description>Property that returns the relative path to the xml file.</description>
    /// </item>
    /// <item>
    /// <term>Serialize</term>
    /// <description>Method that uses the list of flights to create the xml file.</description>
    /// </item>
    /// <item>
    /// <term>DeSerialize</term>
    /// <description>Method that creates a list of flight objects from the xml file.</description>
    /// </item>
    /// <item>
    /// <term>GetFlights</term>
    /// <description>Method that returns the list of flight objects. Must be called after the CreateFlights method.</description>
    /// </item>
    /// <term>CreateFlightSchedule</term>
    /// <description>Private Method that returns the flight schedule in the form of a List of TimeSpan objects.</description>
    /// </item>
    /// </summary>
    public class FlightFactory
    {
        List<Flight> Flights = new List<Flight>();  //Holds all the lights
        XmlSerializer serial;                       //Used to create/read XML file
        Random rand = new Random();                 //Used to randomize numbers

        /// <summary>
        /// CreateFlights method can be called by an outside program to create flights for all known airports.
        /// Values needed are hard coded into this and other methods in the FlightFactory class.
        /// Possible future enhancements could be to accept the values needed as parameters allowing for more flexibility.
        /// </summary>
        public void CreateFlights()
        {
            //Create flights from June to July 2017
            int startFlightNumber = 100;                     //Initial flight number
            DateTime startDate = new DateTime(2017, 06, 01); //Date to start the flights
            int days = DateTime.DaysInMonth(2017, 06);       //Get the days in the month of June 2017
            DateTime endDate = startDate.AddDays(days);      //Add the days in June to the start date to get the end date.
            List<Airport> Airports = Airport.GetAirports();  //Create a list to hold the Airports and get the list from the Airport class.
            

            //Loop through for each day, each airport, each scheudled time and create flights to all known airports.
            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                //Create a variable to hold the Initial flight number. Needed so flight number is the same each day.
                int flightNumber = startFlightNumber; 
                
                //Loop through each airportin the Airports list and create an airport object which will hold the source airport.
                foreach (Airport airp in Airports)
                {
                    //Create a flight schedule and assign it to the temporary airport object
                    airp.FlightSchedule=CreateFlightSchedule();

                    //loop through each flight time in the fligth schedule
                    foreach (TimeSpan tme in airp.FlightSchedule)
                    {
                        //Loop through each airportin the Airports list and create an airport object which will hold the destination airport.
                        foreach (Airport arp2 in Airports)
                        {
                            string test1 = airp.Location;  //Get the source airport name
                            string test2 = arp2.Location;  //Get the Destination airport name

                            //Create a flight to each airport.
                            if (test1 != test2) //do not create flight for same airport
                            {
                                //Get the price for the flight using the source(test1), destination(test2) airports and the time of day(tme)
                                FareGenerator fareGenerator = new FareGenerator(test1, test2, tme, rand);

                                //Create a flight object 
                                Flight temp = new Flight(flightNumber, currentDate + tme, test1, test2, fareGenerator.Fare, 10);

                                //Add the flight to the List
                                Flights.Add(temp);

                                //Increment the flight number 
                                //(Alternatively flight number could have been created as a randomized list)
                                flightNumber++;
                            }

                        }

                    }

                }

            }

            //Sort the flights by date and time.
            List<Flight> SortedList = Flights.OrderBy(o => o.DateAndTime.DayOfYear).ThenBy(o => o.SourceAirport).ThenBy(o => o.DestAirport).ToList();
            //Assign the sorted to Flights
            Flights = SortedList;
           
       

        }

        //Holds the relative path of the XML file
        private string filePath = @"..\..\..\Flight Reservations\flights.xml";

        /// <summary>
        /// FilePath property returns the relative path of where flights.xml  should be stored. 
        /// </summary>
        /// <returns>A string with the relative path of flights.xml</returns>
        public string FilePath
        {
            get { return filePath; }

        }

        /// <summary>
        /// Serialize method creates the flights.xml file using a list of flight objects. Must be called after the CreateObjects() method
        /// or no flights will be displayed.
        /// </summary>
        /// <returns>True if successful/false if error</returns>
        public Boolean Serialize()
        {

            try
            {
                //Serialize the flights
                serial = new XmlSerializer(Flights.GetType());
                StreamWriter sw = new StreamWriter(filePath);
                serial.Serialize(sw, Flights);
                sw.Close();
                return true;

            }
            catch
            {
                //error occurred return false.
                return false;
            }

        }

        /// <summary>
        /// DeSerialize method takes a flights.xml file and creates a List of flight objects
        /// </summary>
        /// <returns>True if successful/false if error</returns>
        public Boolean DeSerialize()
        {
            //Create the list to hold the flights.
            Flights = new List<Flight>();

            try
            {
                //DeSerialize the flights.xml file
                StreamReader sr = new StreamReader(filePath);
                serial = new XmlSerializer(Flights.GetType());
                Flights = (List<Flight>)serial.Deserialize(sr);
                sr.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// GetFlights method returns a list of flight objects.
        /// </summary>
        /// <returns>List of flight objects</returns>
        public List<Flight> GetFlights()
        {
            return Flights;
        }


        /// <summary>
        /// CreateFlightSchedule is a private method that creates a list of times that flights will occur in one 24 hour period.
        /// </summary>
        /// <returns>List of TimeSpan objects</returns>
        private List<TimeSpan> CreateFlightSchedule()
        {
            //holds the times of the day flights will go out
            List<TimeSpan> FlightTimes = new List<TimeSpan>(); 
            
            //loop that controls how many times per day 
            for (int i = 0; i < 4; i++)
            {
                //every 6 hours after 5 AM , "6" controls the hours and "-1" controls the start time
                int interval = ((i + 1) * 6) - 1;

                //create the time using a random for the minues ** Not used
                //TimeSpan FlightSched = new TimeSpan(interval, time.Next(0, 59), 0);

                //Create time to meet "Time schedule will be the same each day" requirement 
                TimeSpan FlightSched = new TimeSpan(interval, 30, 0);
                //add the time to the list
                FlightTimes.Add(FlightSched);
            }

            return FlightTimes; 

        }
    }
}
