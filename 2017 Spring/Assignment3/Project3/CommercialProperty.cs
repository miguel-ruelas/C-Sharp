using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CommercialProperty : Property
    {
        public enum CommercialPropertyType { INDUSTRIAL, OFFICE, RETAIL }
        public CommercialPropertyType type { get; set; }
        private static readonly decimal[] typeModifier = {0.30m, 0.35m, 0.40m };

        public CommercialProperty(string addr, int yr, int sqf, int tpe)
            : base (addr, yr, sqf)
        {
            type = (CommercialPropertyType)tpe;
        }


        public override decimal CalculateCost()
        {
            decimal basePrice = base.CalculateCost();
            decimal ageAdjust = ((decimal)(CurrentYear - yearBuilt) * .001m) * basePrice;
            decimal typeAdjust = basePrice * typeModifier[(int)type];
            return basePrice + typeAdjust - ageAdjust;
        }

        public override string ToString()
        {
            string str = base.ToString() + ", Type:" + type.ToString() +", Cost:" + CalculateCost().ToString("c") ;
            return str;
        }
    }
}
