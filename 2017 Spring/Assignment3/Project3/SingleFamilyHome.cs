using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// holds information about a Single Family Home residential property
    /// </summary>
    class SingleFamilyHome : ResidentialProperty
    {
        private Boolean garage = false;  // true if there is a garage

        /// <summary>
        /// Calls the base class and intializes local variables
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="yr"></param>
        /// <param name="sqf"></param>
        /// <param name="waterFront"></param>
        /// <param name="pools"></param>
        /// <param name="tennisCourts"></param>
        /// <param name="garg"></param>
        public SingleFamilyHome(string addr, int yr, int sqf, bool waterFront,
           int pools, int tennisCourts, Boolean garg) : base (addr, yr, sqf, 
               waterFront, pools, tennisCourts)
        {
            garage = garg;
        }
        /// <summary>
        /// calculate and return the cost of the property.
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateCost()
        {
            decimal basePrice = sqFeet * PRICE_PER_SQF;
            const decimal garageAdjustPercent = .05m;
            
            decimal garageAdjust = 0;
            if (garage == true)
            {
                garageAdjust = basePrice * garageAdjustPercent;
            }

            return base.CalculateCost() + garageAdjust;
        }
        /// <summary>
        /// returns a formatted string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = base.ToString() + ", COST: " + CalculateCost().ToString("c"); 
            return str;
        }
    }
}
