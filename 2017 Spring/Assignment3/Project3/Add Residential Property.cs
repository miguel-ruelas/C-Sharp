using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class AddResidentialProperty : Form
    {
        private Property _property; // Will hold the property to be added

        // Returns the property to Main form
        public Property Property 
        {
            get
            {
                return _property;
            }
            set
            {

            }
        }       
        
        public AddResidentialProperty()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clear all boxes and reset checkboxes
        /// </summary>
        public void Clear()
        {
            streetTextBox.Clear();
            unitTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipCodeTextBox.Clear();
            yearBuiltTextBox.Clear();
            squareFeetTextBox.Clear();
            poolsTextBox.Clear();
            tennisCourtsTextBox.Clear();
            floorTextBox.Clear();
            garageCheckBox.Checked = false;
            waterFrontCheckBox.Checked = false;


        }

       
        /// <summary>
        /// Change Visibility of Form objects based on selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeComboBox.SelectedIndex == 0)
            {
                garageCheckBox.Visible = true;
                floorLabel.Visible = false;
                floorTextBox.Visible = false;

            }
            if (typeComboBox.SelectedIndex == 1)
            {
                garageCheckBox.Visible = false;
                floorLabel.Visible = true;
                floorTextBox.Visible = true;
            }

        }
        /// <summary>
        /// when clicked, attempts to create a property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (CreateProperty(out _property))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            

        }
        /// <summary>
        /// Called to create a property 
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private bool CreateProperty(out Property property)
        {
     
            property = null;
            string address = "";
            int year = 0;
            int sqfeet = 0;
            int pools = 0;
            int tennisCourts = 0;
            int floor = 0;
            bool wtrFrnt = false;
            bool garg = false;

            try
            {
                if (validateForm())  // Check user input
                {
                    //Process user input
                    string s = " ";
                    string c = ",";
                    address = streetTextBox.Text + s + unitTextBox.Text + c + s + cityTextBox.Text + c + s
                        + stateTextBox.Text + c + s + zipCodeTextBox.Text;
                    int.TryParse(yearBuiltTextBox.Text, out year);
                    int.TryParse(squareFeetTextBox.Text, out sqfeet);
                    int.TryParse(poolsTextBox.Text, out pools);
                    int.TryParse(tennisCourtsTextBox.Text, out tennisCourts);
                    int.TryParse(floorTextBox.Text, out floor);
                    wtrFrnt = waterFrontCheckBox.Checked;
                    garg = garageCheckBox.Checked;

                    //Create property type based on user selection.
                    if (typeComboBox.SelectedIndex == 0)
                    {
                        SingleFamilyHome home = new SingleFamilyHome(address, year, sqfeet, wtrFrnt, pools, tennisCourts, garg);
                        property = home;

                    }
                    if (typeComboBox.SelectedIndex == 1)
                    {
                        Apartment apt = new Apartment(address, year, sqfeet, wtrFrnt, pools, tennisCourts, floor);
                        property = apt;

                    }
                    return true;
                }

            }
            catch
            {
                property = null;
                return false;
            }
           
            return false;

        }
        /// <summary>
        /// Check user input
        /// </summary>
        /// <returns></returns>
        private bool validateForm()
        {
            
            if(streetTextBox.Text == "")
            {
                MessageBox.Show("Enter a valid Address");
                return false;
            }
            if (cityTextBox.Text == "")
            {
                MessageBox.Show("Enter a valid City");
                return false;
            }
            if (unitTextBox.Text == "")
            {
                MessageBox.Show("Enter a valid Unit");
                return false;
            }
            if (stateTextBox.Text == "")
            {
                MessageBox.Show("Enter a valid State");
                return false;
            }
            if (zipCodeTextBox.Text == "")
            {
                MessageBox.Show("Enter a valid Zipcode");
                return false;
            }
         
            int x;
            if((!int.TryParse(yearBuiltTextBox.Text, out x)) || x < 1800 || x > 2017)
            { 
                MessageBox.Show("Enter a valid year");
                return false;
            }
            if (!int.TryParse(squareFeetTextBox.Text, out x) || x < 100 || x > 10000)
            {
                MessageBox.Show("Enter a valid number for Square Feet");
                return false;
            }
            if (!int.TryParse(poolsTextBox.Text, out x))
            {
                MessageBox.Show("Enter a valid number for pools");
                return false;
            }
            if (!int.TryParse(tennisCourtsTextBox.Text, out x))
            {
                MessageBox.Show("Enter a valid number for Tennis Courts");
                return false;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                if (!int.TryParse(floorTextBox.Text, out x))
                {
                    MessageBox.Show("Enter a valid number for Floors");
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Set selection of typeComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddResidentialProperty_Load(object sender, EventArgs e)
        {
            typeComboBox.SelectedIndex = 0;
        }
    }
}
