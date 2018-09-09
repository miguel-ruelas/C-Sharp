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
    public partial class AddCommercialProperty : Form
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

        public AddCommercialProperty()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clear all boxes and reset checkboxes
        /// </summary>
        public void Clear()
        {
            comStreetTextBox.Clear();
            unitTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipCodeTextBox.Clear();
            yearBuiltTextBox.Clear();
            squareFeetTextBox.Clear();

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
            int type = 0;

            try
            {
                if (validateForm()) // Check user input
                {
                    //Process user input
                    string s = " ";
                    string c = ",";
                    address = comStreetTextBox.Text + s + unitTextBox.Text
                        + c + s + cityTextBox.Text + c + s
                        + stateTextBox.Text + c + s + zipCodeTextBox.Text;
                    int.TryParse(yearBuiltTextBox.Text, out year);
                    int.TryParse(squareFeetTextBox.Text, out sqfeet);
                    type = typeComboBox.SelectedIndex;
                    property = new CommercialProperty(address, year, sqfeet, type);

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
            if (comStreetTextBox.Text == "")
            {
                MessageBox.Show("Enter a valid Address");
                return false;
            }
            if (unitTextBox.Text == "")
            {
                MessageBox.Show("Enter a valid Unit");
                return false;
            }
            if (cityTextBox.Text == "")
            {
                MessageBox.Show("Enter a valid City");
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
            if ((!int.TryParse(yearBuiltTextBox.Text, out x)) || x < 1800 || x > 2017)
            {
                MessageBox.Show("Enter a valid year");
                return false;
            }
            if (!int.TryParse(squareFeetTextBox.Text, out x) || x < 100 || x > 10000)
            {
                MessageBox.Show("Enter a valid number for Square Feet");
                return false;
            }        
          
            return true;
        }
        /// <summary>
        /// when clicked, attempts to create a property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {

            if(CreateProperty(out _property))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        /// <summary>
        /// Set selection of typeComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCommercialProperty_Load(object sender, EventArgs e)
        {
            typeComboBox.SelectedIndex = 0;
        }
    }
}
