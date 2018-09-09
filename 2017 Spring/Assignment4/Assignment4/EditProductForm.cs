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
    /// The EditProductForm class displays a form with input boxes for the ID, Name, Description,
    /// price and quantity of a product that is to be edited. Upon editing a product
    /// the class calls the main form using the refreshAll() method.
    /// </summary>
    public partial class EditProductForm : Form
    {
        private Form1 parent;
        int recIndex=0;
        Product editProd;
        /// <summary>
        /// EditProductForm() is a no argument constructor that initializes the form;
        /// </summary>
        public EditProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EditProductForm() is an overloaded constructor that accepts a reference to the main form and the index of the
        /// product that is to be edited. It then sets internal variables with the values received.
        /// </summary>
        /// <param name="indx"></param>
        /// <param name="parentIn"></param>
        public EditProductForm(int indx, Form1 parentIn ) : this()
        {
            parent = parentIn;
            recIndex = indx;
     

            
        }

        /// <summary>
        /// EditProductForm() is an overloaded constructor that accepts a reference to the main form. It then sets 
        /// internal variable with the value received.
        /// </summary>
        /// <param name="parentIn"></param>
        public EditProductForm(Form1 parentIn) : this()
        {
            recIndex = 0;
            parent = parentIn;
            
        }


        /// <summary>
        /// updateTextBox() is called to get the values for id, name, description, price and quantity of a product in 
        /// inventory and assign them to the appropriate text box for the user to edit.
        /// </summary>
        private void updateTextBox()
        {
            idTextBox.Text = editProd.ID;
            nameTextBox.Text = editProd.Name;
            descTextBox.Text = editProd.Desc;
            priceTextBox.Text = editProd.Price.ToString();
            qtyTextBox.Text = editProd.Qty.ToString();

        }
        /// <summary>
        /// button2_Click is an event handler for the exit button. It closes the form.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// button1_Click is an event handler for the Save button. It validates user input and if the tests pass
        /// it creates a new object product object and replaces the old one by assigning it to the index location
        /// in the product list object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string iD = "";
            string name = "";
            string desc = "";
            decimal price = 0;
            int qty = 0;
            //check the input
            if (validateNumber(priceTextBox) && validateNotNull(priceTextBox))
            {
                Decimal.TryParse(priceTextBox.Text, out price);
                if (validateNumber(qtyTextBox) && validateNotNull(qtyTextBox))
                {
                    int.TryParse(qtyTextBox.Text, out qty);
                    if (validateNotNull(idTextBox) && validateUnique(idTextBox))
                    {
                        //input checks good, create a product object
                        iD = idTextBox.Text;
                        name = nameTextBox.Text;
                        desc = descTextBox.Text;

                        Product edited = new Product(iD, name, desc, price, qty);
                        int index = prodListComoboBox.SelectedIndex;
                        //Replace the old product with the new one.
                        Form1.products[prodListComoboBox.SelectedIndex] = edited;
                        //this test was for debugging, if parent is null program will crash
                        if( parent == null)
                        {
                            MessageBox.Show("error parent is null");
                        }
                        else
                        {
                            parent.refreshAll();   //Parent is not null, call refreshAll() method
                        }
                       
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// prodListComoboBox_SelectionChangeCommitted_1() is an event handler that detects when the user selects
        /// a different product from the list. It then sets that product as the product to be edited by asining it 
        /// to a local variable.
        ///  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prodListComoboBox_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            editProd = prodListComoboBox.SelectedItem as Product;
            updateTextBox();
        }

        /// <summary>
        /// validateNumber() receives a textBox object and checks its input to see if it is a number.
        /// </summary>
        /// <param name="testBox"></param>
        /// <returns></returns>>
        private bool validateNumber(TextBox testBox)
        {
            //get the text from the textbox;
            string testText = testBox.Text;
            bool isInt = false;              // to state whether or not the test passes
            //Check each element in the string
            bool prior = true;    //use to check the result of prior element in string
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
            if (!(testText == "" || testText == null))
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
            validateNotNull(idTextBox);
            validateUnique(idTextBox);
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
        /// EditProductForm_Load() sets the productListComboBox source and selected index. It gets the product at 
        /// the selected index and assigns it to a local variable. It then calls the updateTextBox() method to 
        /// get the product information and display it in the appropriate text box for the user to edit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            
            prodListComoboBox.DataSource = Form1.products;
            prodListComoboBox.DisplayMember = "ID";
            this.prodListComoboBox.SelectedIndex = recIndex;
            editProd = Form1.products.ElementAt(recIndex) as Product;
            updateTextBox();
        }
    }
}
