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
    public partial class addProductQTY : Form
    {
        Product addProd;
        public addProductQTY(Product addProdin)
        {
            InitializeComponent();
            addProd = addProdin;
           
        }

        private void addProductQTY_Load(object sender, EventArgs e)
        {
            enterLabel.Text = "Product:" + addProd.ID + " has " + 
                addProd.Qty + " in stock. Please enter the quantity to add to sale." ;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Determine if the TextBox has a digit character.
            string text = textBox1.Text;
            bool hasDigit = false;
            foreach (char letter in text)
            {
                if (char.IsDigit(letter))
                {
                    hasDigit = true;
                    break;
                }
            }
            // Call SetError or Clear on the ErrorProvider.
            if (!hasDigit)
            {
                errorProvider1.SetError(textBox1, "Needs to contain a digit");
            }
            else
            {
                errorProvider1.Clear();
            }

        }
    }
}
