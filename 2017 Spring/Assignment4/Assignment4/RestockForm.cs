using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory;

namespace Assignment4
{
    /// <summary>
    /// RestockForm is a class that presents a form inventory products that have a quantity
    /// below a set threshold. Future releases will allow the user to change the threshold. 
    /// </summary>
    public partial class RestockForm : Form
    {
        int threshold = 5;   //Form shows items below this number
        /// <summary>
        /// RestockForm() is a no argument constructor that initializes the form and adds a custom 
        /// form header that tells the user what the threshold value is.
        /// </summary>
        public RestockForm()
        {
            InitializeComponent();
            this.Text = "Restock Produts: Displaying Products below " + threshold;
        }

        /// <summary>
        /// RestockForm_Load() generates the list of items that are below the threshold 
        /// from the product list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestockForm_Load(object sender, EventArgs e)
        {
            foreach(Product temp in Form1.products)
            {
                if (temp.Qty<threshold)
                {
                    restockList.Items.Add(temp.ID + " " + temp.Name);
                }
            }
        }

        /// <summary>
        /// button2_Click is an event handler for the exit button and closes this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// Future releases will have implementation to print the list.
    }
}
