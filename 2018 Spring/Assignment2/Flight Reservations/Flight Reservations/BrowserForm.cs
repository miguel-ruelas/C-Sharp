using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///This program was created as a coursework assignment by
///@Author   : Miguel A. Ruelas Jacobo
///For:
///Course    : COP 4814 Component Based Software Development U01
///Professor : Kip Irvine
///Assignment:Assignment 1
///Due Date : 02/11/2018
/// </summary>
namespace FlightReservationGui
{
    public partial class BrowserForm: Form
    {
        public String URL { get; set; }
        private string appPath;

        /// <summary>
        /// Displays a web browser readable file.
        /// </summary>
        public BrowserForm()
        {
            InitializeComponent();
            String path = Application.ExecutablePath;
            int index = path.LastIndexOf("\\");
            appPath = path.Substring(0, index) + @"\..\..\";
        }

        private void BrowserForm_Load(object sender, EventArgs e)
        {
            String temp = "file://" + appPath + this.URL;
            this.Text = temp;           
            webBrowserControl.Navigate(temp);
        }
    }
}
