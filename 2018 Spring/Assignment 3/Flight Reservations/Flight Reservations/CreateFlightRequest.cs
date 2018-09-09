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
    /// <summary>
    /// Updated for assignment 3 to allow for assignment 2 and assignment 3 links to both function.
    /// </summary>
    public partial class CreateFlightRequest : Form
    {
        private ReservationFactory temp = new ReservationFactory();

        private String version = "2.0";   //modified at runtime to provide new support

        public CreateFlightRequest()
        {
            InitializeComponent();
        }

        public CreateFlightRequest(String ver)
        {
            if (ver == "1.3")   //modify the version of the form
            {
                version = ver;

            }

            InitializeComponent();
        }

        private void FlightRequest_Load(object sender, EventArgs e)
        {
            this.Text = "Flight Reservations " + version; 
            if (version == "1.3")   //change behaviour at runtime based on version
            {
                this.Width = 600;
                Size test = new Size(200, 33);
                btnSearch.MinimumSize = test;
                btnSearch.Size = test;
                btnSearch.Text = "Show all matches";                
                Point loc = new Point(370, 21);

                btnSearch.Location= loc;
                



            }

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
                //send version to Reservation factory which will send to serialize to alter behaviour based on version
                    temp.findFlights(lstbxSearchResults.SelectedIndex, version); 
                    BrowserForm frm = new BrowserForm();
                    frm.URL = temp.FileName;
                    frm.ShowDialog();
                }

            

            
            
            



        }
    
    }
}
