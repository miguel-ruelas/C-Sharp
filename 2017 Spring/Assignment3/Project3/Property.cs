using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// Base class for all properties
    /// </summary>
    abstract public class Property
    {
        public string address { get; set; }
        public int yearBuilt { get; set; }
        public int sqFeet { get; set; }

        public static int CurrentYear => currentYear;

        public const decimal PRICE_PER_SQF = 100.0m;
        private static int currentYear = 2017;

        /// <summary>
        /// Constructor sets initial variables
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="yr"></param>
        /// <param name="sqf"></param>
        public Property (string addr, int yr, int sqf)
        {
            address = addr;
            yearBuilt = yr;
            sqFeet = sqf;
        }
            
        /// <summary>
        /// calculate the base price
        /// </summary>
        /// <returns></returns>
        virtual public decimal  CalculateCost()
        {
            decimal basePrice =  sqFeet* PRICE_PER_SQF;
            
            return basePrice;
        }

        /// <summary>
        /// Returns a formatted string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = address.ToString() + ", YEAR: " + yearBuilt.ToString() + ", SQFT:" + sqFeet.ToString();
            return str;
        }
    }
}
