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
    public partial class Form1 : Form
    {
        // Creates the form to add a residential property
        private AddResidentialProperty addResForm = new AddResidentialProperty();

        // Creates the form to add a Commercial property
        private AddCommercialProperty addComForm = new AddCommercialProperty();
        
        // Create object to hold the property objects
        private PropertyDB property = new PropertyDB();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Clear all forms
            addComForm.Clear(); 
            addResForm.Clear();
            
            //Clear the property report List 
            propertyListBox.Items.Clear();

            // Check to see which type of property the user wants to add
            if (commercialRadioButton.Checked)
            {
                //Show the form and check to see if property was created
                if (DialogResult.OK == addComForm.ShowDialog())  
                {
                    MessageBox.Show(addComForm.Property.ToString() + " successfully added");
                    property.Add(addComForm.Property); //add property to database/list
                }
            }
            else if (residentialRadioButton.Checked)
            {
                //Show the form and check to see if property was created
                if (DialogResult.OK == addResForm.ShowDialog())
                {
                    MessageBox.Show(addResForm.Property.ToString() + " successfully added");
                    property.Add(addResForm.Property); //add property to database/list
                }
            }
            // add the properties to the list by calling the ToString() method of each object.
            foreach(Property p in property.getList() )
            {
                
                propertyListBox.Items.Add(p.ToString()); //add each property to the list
                decimal total = property.getTotal();      // Get the total cost of all properties in list
                costDisplayLabel.Text = total.ToString("c"); //Show the total cost to user.


            }
               
            
        }

        /// <summary>
        /// show a larger form with all the properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printReportButton_Click(object sender, EventArgs e)
        {
            List<Property> p = property.getList();   // Get the list
            Report reportForm = new Report(p);      // Create and Pass the list to the form
            reportForm.ShowDialog();               // Show the form
        }
    }
}
