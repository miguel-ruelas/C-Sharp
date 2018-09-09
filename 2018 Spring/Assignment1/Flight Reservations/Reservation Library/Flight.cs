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
namespace Flights
{
    /// <summary>
    /// Flight class holds information regarding a flight from one airport to another. 
    /// </summary>
    public class Flight
    {
        private int flightNumber;
        private DateTime dateAndTime;
        private string sourceAirport;
        private string destAirport;
        private double fare;
        private int seats;

        //Empty Constructor creates a flight object. Could be useful if all flight information is not available.
        public Flight()
        {

        }

        /// <summary>
        /// Flight an overloaded constructor that initializes all values needed for a flight.
        /// </summary>
        /// <param name="fn">An integer corresponding to the Flight Number</param>
        /// <param name="tm">A DateTime object corresponding to a date and a time of a flight</param>
        /// <param name="orig">A three letter string corresponding the to source airport</param>
        /// <param name="dest">A three letter string corresponding the to Destination airport</param>
        /// <param name="fr">A double containing the price of the flight</param>
        /// <param name="sts">An integer representing the number of seats in a flight</param>
        public Flight(int fn, DateTime tm,string orig,string dest, double fr, int sts)
        { 
            //Assign the values received to internal variables.
            this.FlightNumber = fn;
            this.DateAndTime = tm;
            this.SourceAirport = orig;
            this.DestAirport = dest;
            this.Fare = fr;
            this.Seats = sts;
        }

        /// <summary>
        /// FlightNumber property gets and sets the flightnumber of this flight. Depending on 
        /// company need, it may be needed to remove the "set" function if flightnumbers of flights
        /// can never be changed.
        /// </summary>
        public int FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }


        /// <summary>
        /// DateAndTime gets and sets the date and time of this flight.
        /// </summary>
        public DateTime DateAndTime
        {
            get { return dateAndTime; }
            set { dateAndTime = value; }

        }
        /// <summary>
        /// SourceAirport gets and sets the source airport of this flight.
        /// </summary>
        public string SourceAirport
        {
            get { return sourceAirport; }
            set { sourceAirport = value; }
        }

        /// <summary>
        /// DestAirport gets and sets the destination airport of this flight.
        /// </summary>
        public string DestAirport
        {
            get { return destAirport; }
            set { destAirport = value; }
        }
        /// <summary>
        /// Fare gets and sets the price of this flight
        /// </summary>
        public double Fare
        {
            get { return fare; }
            set { fare = value; }
        }

        /// <summary>
        /// Seats gets and sets the number of seats in this flight.
        /// 
        /// </summary>
        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }
       

        /// <summary>
        /// Returns a formated string with the flight information.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
            string str = String.Format("{0}, {1:MM/dd/yyyy} at {2:HH:mm}, {3} to {4}, COST: {5,6:####.0}, Seats: {6,3} ", 
                flightNumber, dateAndTime, dateAndTime,
                sourceAirport, destAirport,fare, seats);
                //.ToString("MM-dd-yyyy")
            return str;
        }

    }
}
