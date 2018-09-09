using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationGui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lnklblAssignment1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           CreateFilesForm assignment1 =  new CreateFilesForm();
           assignment1.Show();
        }

        private void lnklblAssignment2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateFlightRequest assignment2 = new CreateFlightRequest();
            assignment2.Show();

        }
    }
}
