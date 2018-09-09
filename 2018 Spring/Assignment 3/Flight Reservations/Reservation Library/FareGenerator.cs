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
namespace Reservation_Library
{
    /// <summary>
    /// FareGenerator contains all the methods needed to create the price of a flight.
    /// </summary>
    public class FareGenerator
    {
        //Holds the price per mile
        private double basePricePerMile = .55 ;

        /// <summary>
        /// FareGenerator constructor receives a source and destination airport, a time of day(TimeSpan) and a Random object.
        /// Based on the information received it computes a random price for one flight.
        /// </summary>
        /// <param name="source">A three letter string containing the source Airport</param>
        /// <param name="dest">A three letter string containing the Destination Airport</param>
        /// <param name="flightTime">A TimeSpan object containing an hour, minute, seconds time of day</param>
        /// <param name="rand">Random object used to create better random values</param> 
        public FareGenerator(string source, string dest, TimeSpan flightTime, Random rand)
        {
            //Get the distance between source and destination Airports
            //Assumption that source and destination inputs have been previously validated. If erronous this will return 0
            int distance = getDistance(source, dest);
            
            //Get time Multiplier based on time of day
            double timeMultipler = getMultiplier(flightTime);

            //Calculate the price.
            double price = rand.Next(50,300) + (basePricePerMile * distance * timeMultipler);
            
            //Round the result to two decimal places
            double result = Math.Round(price,2);

            //Validate the price is within company price model  between 500-3000
            if (result < 500)
            {
                result = 500;
            }
            else if (result > 3000)
            {
                result = 3000;
            }
            
            //Return the result
            this.Fare = result;

        }

        /// <summary>
        /// getMultiplier is a private class that returns a value used to adjust the price of a 
        /// flight based on the time of the day. There are three time sections, midnight to 8 AM, 
        /// 8 AM to 8 PM, and 8 PM to midnight. 0 is returned if an invalid time is received 
        /// </summary>
        /// <param name="flightTime"></param>
        /// <returns>A double containing a value used to adjust the price of a flight</returns>
        private double getMultiplier(TimeSpan flightTime)
        {
            //Create time objects to section off a 24 hour period.
            TimeSpan eightAM = new TimeSpan(8,0,0);
            TimeSpan eightPM = new TimeSpan(20, 0, 0);
            
            //Check time received against time objects and return the multiplier value.
            if (flightTime <= eightAM)
            {
                return 1.1;
            }
            else if (flightTime <= eightPM)
            {
                return 1.5;
            }
            else if (flightTime > eightPM)
            {
                return 1.25;
            }
            return 0; //This will make the price zero if an invalid time was received

        }

        /// <summary>
        /// Fare property holds the price of a flight. 
        /// </summary>
        public double Fare { get;  }

        /// <summary>
        /// getDistance returns the distance in miles(as an int) between two airports.
        /// </summary>
        /// <param name="source">A three letter string containing the source Airport</param>
        /// <param name="dest">A three letter string containing the Destination Airport</param>
        /// <returns></returns>
        private int getDistance(string source, string dest)
        {
            //Create a list using source and destinations trings
            List<string> test = new List<string> { source, dest };

            //Create a string comparer object used to sort the list of strings received
            StringComparer currICCmp = StringComparer.CurrentCultureIgnoreCase;

            //sort the list alphabetically 
            test.Sort(currICCmp);
            
            //Place the first alphabetically sorted aiport in source and the second in destination
            source = test.ElementAt(0);
            dest = test.ElementAt(1);
            
            //Create a string to match a case in switch, works only if string of airport is in alphabetical order
            String airports = source + "to" + dest;

            //Use switch to return distances between airpotrs.
            switch(airports)
            {
                case "DENtoLAX": return 831;

                case "DENtoMIA": return 1728;

                case "DENtoSEA": return 1021;

                case "LAXtoMIA": return 2338;

                case "LAXtoSEA": return 955;

                case "MIAtoSEA": return 2722;

                default:
                    break;
            }
            return 0; //Return 0 if invalid airports were received.
        }
    }
}
