using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// Holds information about a Residential property
    /// </summary>
    class ResidentialProperty : Property
    {
        private List<Addition> additions = new List<Addition>(); //List of additions 

        /// <summary>
        /// Constructor calls base class and initializes local variables.
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="yr"></param>
        /// <param name="sqf"></param>
        /// <param name="waterFront"></param>
        /// <param name="pools"></param>
        /// <param name="tennisCourts"></param>
        public ResidentialProperty(string addr, int yr, int sqf, bool waterFront, 
            int pools, int tennisCourts) : base (addr, yr, sqf)
        {
            createAdditions(waterFront, pools, tennisCourts);
        }
        /// <summary>
        /// add additions based on user input
        /// </summary>
        /// <param name="waterFront"></param>
        /// <param name="pools"></param>
        /// <param name="tennisCourts"></param>
        private void createAdditions(bool waterFront, int pools, int tennisCourts)
        {
            if (waterFront == false && pools == 0 && tennisCourts == 0)
                return;
            if (waterFront== true)
            {
                WaterFront wtr = new WaterFront();
                additions.Add(wtr);
            }
            if(pools>0)
            {
                Pool pl = new Pool(pools);
                additions.Add(pl);
            }
            if(tennisCourts>0)
            {
                TennisCourt tn = new TennisCourt(tennisCourts);
                additions.Add(tn);
            }
            return;                
        }
        /// <summary>
        /// calculates and returns the cost of the property
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateCost()
        {
            const decimal ageAdjustPercent = .001m;
            const decimal poolAdjustPercent = .10m;
            const decimal tennisAdjustPercent = .15m;
            const decimal wtfntAdjustPercent = .20m;

            decimal basePrice = base.CalculateCost();
            decimal ageAdjust = ((decimal)(CurrentYear - yearBuilt) * ageAdjustPercent) * basePrice;
            decimal poolAdjust = 0;
            decimal tennisAdjust = 0;
            decimal wtfntAdjust = 0;

            foreach (Addition a in additions)
            {

                if (a.GetType() == typeof(Pool))
                {
                    Pool p = (Pool)a;
                    poolAdjust = (basePrice * poolAdjustPercent) * p.qty;
                }
                if (a.GetType() == typeof(TennisCourt))
                {
                    TennisCourt t = (TennisCourt)a;
                    tennisAdjust = (basePrice * tennisAdjustPercent) * t.qty;
                }
                if (a.GetType() == typeof(WaterFront))
                {
                  
                    wtfntAdjust = (basePrice * wtfntAdjustPercent);
                }
            }

            return basePrice - ageAdjust + poolAdjust + tennisAdjust + wtfntAdjust;
            
        }
        /// <summary>
        /// returns a formatted string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = base.ToString() ;
            return str;
        }
    }
}
