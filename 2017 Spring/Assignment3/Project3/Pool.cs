using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// This addition holds the amount of pools in a residential property 
    /// </summary>
    class Pool : Addition
    {
        public int qty { get; set; }

        public Pool (int qy)
        {
            qty = qy;
        }
    }
}
