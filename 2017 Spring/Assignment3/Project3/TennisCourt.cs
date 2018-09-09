using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// This addition holds the amount of tennis courts in a residential property 
    /// </summary>
    class TennisCourt : Addition
    {
        public int qty { get; set; }

        public TennisCourt(int qy)
        {
            qty = qy;
        }
    }
}
