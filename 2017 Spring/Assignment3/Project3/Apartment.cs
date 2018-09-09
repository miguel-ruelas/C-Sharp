using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Apartment : ResidentialProperty
    {
        private int floor; 

        /// <summary>
        /// Constructor calls base class and sets floor variable.
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="yr"></param>
        /// <param name="sqf"></param>
        /// <param name="waterFront"></param>
        /// <param name="pools"></param>
        /// <param name="tennisCourts"></param>
        /// <param name="flr"></param>
        public Apartment(string addr, int yr, int sqf, bool waterFront,
                  int pools, int tennisCourts, int flr) : base (addr, yr, sqf, 
               waterFront, pools, tennisCourts)
        {
            floor = flr;
        }
        /// <summary>
        /// calculates the price of the apartment.
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateCost()
        {
            decimal basePrice = sqFeet * PRICE_PER_SQF;
            const decimal floorAdjustPercent = .005m;

            decimal floorAdjust = 0;
            if (floor > 1)
            {
                floorAdjust = basePrice * ((floor - 1) * floorAdjustPercent);
            }

            return base.CalculateCost() + floorAdjust;
        }
        /// <summary>
        /// Returns a formatted string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = base.ToString() + ", COST: " + CalculateCost().ToString("c"); 
            return str;
        }
    }
}