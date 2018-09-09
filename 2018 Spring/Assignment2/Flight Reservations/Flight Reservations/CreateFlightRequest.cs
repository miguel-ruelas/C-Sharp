using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservation_Library;

namespace FlightReservationGui
{
    public partial class CreateFlightRequest : Form
    {
        private ReservationFactory temp = new ReservationFactory();

        public CreateFlightRequest()
        {
            InitializeComponent();
        }

        private void FlightRequest_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCreFliReq_Click(object sender, EventArgs e)
        {
            
            temp.CreateFlightRequest();
            lstbxSearchResults.Items.Clear();
            foreach (FlightRequest i in temp.GetRequests())
            {
                string flight = i.ToString();
                lstbxSearchResults.Items.Add(flight);

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lstbxSearchResults.SelectedIndex < 0)
            {

            }
            else
            {
                temp.findFlights(lstbxSearchResults.SelectedIndex);
                BrowserForm frm = new BrowserForm();
                frm.URL = temp.FileName;
                frm.ShowDialog();
            }
            



        }
    
    }
}
