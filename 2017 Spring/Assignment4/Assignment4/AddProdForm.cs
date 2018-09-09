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
    /// The addProdForm class displays a form with input boxes for the ID, Name, Description,
    /// price and quantity of a product that is to be added to the inventory. Upon adding a product
    /// the class calls the main form using the refreshAll() method.
    /// </summary>
    public partial class AddProdForm : Form
    {
        Form1 parent;       //Will hold a reference to the main form. Used to refresh all other forms
        Product newProd;    //A new product to be added.

        /// <summary>
        /// AddProdForm() constructor receives a reference tot he main Form, and sets the parent variable
        /// to it. 
        /// </summary>
        /// <param name="parentIn"></param>
        public AddProdForm(Form1 parentIn)
        {
            parent = parentIn;
            InitializeComponent();
        }

        /// <summary>
        /// button1() is an event handler for when the "Save" button is clicked. It calls methods to validate
        /// the input, then creates a product, sends it to the main Form and calls the main forms refreshAll()
        /// method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string iD = ""  ;      // holds the id of a product
            string name = "";      // holds the name of a product
            string desc = "";      // holds the description of a product
            decimal price=0;       // holds the price of a product
            int qty=0;             // holds the qty of a product

            //validate all input
            if (validateNumber(priceTextBox) && validateNotNull(priceTextBox))
            {
                Decimal.TryParse(priceTextBox.Text, out price);
                if (validateNumber(qtyTextBox) && validateNotNull(qtyTextBox))
                {
                    int.TryParse(qtyTextBox.Text, out qty);
                    if (validateNotNull(idTextBox) && validateUnique(idTextBox))
                    {
                        iD = idTextBox.Text;
                        name = nameTextBox.Text;
                        desc = descTextBox.Text;
                        //Input checks good, create the product and refresh all.
                        newProd = new Product(iD, name, desc, price, qty);
                        Form1.products.Add(newProd);
                        MessageBox.Show("Product:" + newProd.ID + " has been added!");
                        parent.refreshAll();

                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// validateNumber() receives a textBox object and checks its input to see if it is a number.
        /// </summary>
        /// <param name="testBox"></param>
        /// <returns></returns>
        private bool validateNumber(TextBox testBox)
        {
            //get the text from the textbox;
            string testText = testBox.Text;
            bool isInt = false;              // to state whether or not the test passes
            //Check each element in the string
            bool prior= true;    //use to check the result of prior element in string
            bool current = false;   //used to set the current element in string
            //test each element, if prior element is false, all subsequent elements will be false.
            foreach (char letter in testText)      
            {
                if (char.IsDigit(letter))
                {
                    current = true;
                    prior = (prior && current);
                }
                else
                {
                    current = false;
                }
            }
            isInt = current;   // set the result to bool variable and check if true or false
            if (!isInt)        // if it is not an int then it is false and set the error
            {
                checkNumber.SetError(testBox, "Needs to be a number");
            }
            else
            {
                checkNumber.Clear(); //clear the error in case it was false previously.
            }
            return isInt;   //return true that all char's in textbox are numbers.

        }

        /// <summary>
        /// validateNotNull() checks if a TextBox item is blank and returns true if it is not blank.
        /// </summary>
        /// <param name="testBox"></param>
        /// <returns></returns>
        private bool validateNotNull(TextBox testBox)
        {
            string testText = testBox.Text;
            bool notBlank = false;

            //test if it is blank by checking that it is not null or empty string.
            if (!(testText =="" || testText == null))   
            {
                notBlank = true;      // TextBox is not blank set to true. 
            }
            else
            {
                notBlank = false;  // TextBox is blank set to false
            }
            if (!notBlank)
            {
                checkNumber.SetError(testBox, "Cannot be blank");  //display error
            }
            else
            {
                checkNumber.Clear();   //clear previous errors if corrected
            }
            return notBlank;   //return result, true if not blank, false if blank

        }

        /// <summary>
        ///  validateUnique() checks to make sure the ID entered is not one that is already in 
        ///  inventory.
        /// </summary>
        /// <param name="testBox"></param>
        /// <returns></returns>
        private bool validateUnique(TextBox testBox)
        {
            
            string testID = testBox.Text;  //get the id entered
            string existingID;             //holds the ID of products in inventory
            bool unique = false;           // false not unique until code proves that it is.

            //Check every product.
            foreach (Product test in Form1.products)
            {
                    existingID = test.ID;  //get the id 

                    if (String.Compare(existingID, testID) == 0)  //compare it to the one in text box
                    {
                        //ID's are the same set the error and exit out of method.
                        checkNumber.SetError(testBox, "ID is the same as another product, please enter a different ID");
                        return unique;
                    }
                
            }
            checkNumber.Clear();   //Clear any previous errors 
            unique = true;         // ID match not found so set unique to true
            return unique;         //Return true 
        }
    

        /// <summary>
        /// button2_click is an event handler for the exit button. It closes this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }


        /// <summary>
        /// qtyTextBox_TextChanged() is an event handler for detecting new input in the qtyTextBox.
        /// if input is detected, it validates it and sets an error if found.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            validateNumber(qtyTextBox);

        }

        /// <summary>
        /// priceTextBox_TextChanged() is an event handler for detecting new input in the priceTextBox.
        /// if input is detected, it validates it and sets an error if found.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            validateNumber(priceTextBox);

        }

        /// <summary>
        /// idTextBox_TextChanged() is an event handler for detecting new input in the idTextBox.
        /// if input is detected, it validates it and sets an error if found.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            validateUnique(idTextBox);
        }
    }
}
