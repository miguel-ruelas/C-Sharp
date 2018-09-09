using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservation_Library;

namespace FlightReservationGui
{
    public partial class MatchingMultiCityFlights : Form
    {
        
        private List<ConnectingFlights> list;

        public MatchingMultiCityFlights()
        {
            InitializeComponent();
        }

        public MatchingMultiCityFlights(List<ConnectingFlights> list)
        {
            this.list = list;
            InitializeComponent();

        }

        private void MatchingMultiCityFlights_Load(object sender, EventArgs e)
        {
            list.Sort(delegate (ConnectingFlights c1, ConnectingFlights c2) { return c1.GetDuration.CompareTo(c2.GetDuration); });
            foreach (ConnectingFlights con in list)
            {
                lbxResults.Items.Add(con.ToString());
            }

        }
    }
}
