using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// Used to hold properties
    /// </summary>
    class PropertyDB
    {

        List<Property> property = new List<Property>();

        /// <summary>
        /// Adds new properties
        /// </summary>
        /// <param name="p"></param>
        public void Add(Property p)
        {
            property.Add(p);
        }
        /// <summary>
        /// Returns a copy of the property list
        /// </summary>
        /// <returns></returns>
        public List<Property> getList()
        {
            List<Property> result = new List<Property>();
            foreach (Property p in property)
            {
                result.Add(p);

            }
            return result;
        }
        /// <summary>
        /// returns the total cost of all properties in the list
        /// </summary>
        /// <returns></returns>
        public decimal getTotal()
        {
            decimal total= 0;

            foreach (Property p in property)
            {
                total += p.CalculateCost();

            }

            return total;

        }
    }
}

