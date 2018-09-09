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
using Microsoft.VisualBasic;

namespace Assignment4
{
    /// <summary>
    /// PointOfSale is a class that displays a form that can be used to conduct a sale of products in an 
    /// inventory. It generates buttons for each product that is in stock and displays a list of items as 
    /// they are added to the list. A checkbox changes the way the buttons function, if checked the buttons 
    /// display an new form for the user to enter a quantity. If unchecked the button will add 1 product
    /// to the list of items to be sold. It has a remove button which removes items from the list to be sold
    /// and also updates the quantity in stock of the item. There is a Print receipt button that will create 
    /// a text file that can be printed as the receipt. Future functionality would add a method to automatically
    /// print the receipt from a thermal printer and log the transaction in a database.
    /// </summary>
    public partial class PointOfSale : Form
    {
        //Create a list that holds all the buttons
        List<Button> buttons = new List<Button>();

        //Create a newSale object which holds the items to be sold and tallies the total
        Sale newSale = new Sale();

        //Variable to hold a reference to the main form. Used to call the refreshAll() method and update all forms.
        Form1 parent;

        /// <summary>
        /// PointOfSale() accepts a reference to the main form and assigns it to a local variable. It then initializes
        /// the form.
        /// </summary>
        /// <param name="parentIn"></param>
        public PointOfSale(Form1 parentIn)
        {
            parent = parentIn;
            InitializeComponent();
        }

        /// <summary>
        /// PointOfSale_Load() calls the loadButtons() and setButtonLoc() methods to create a button for each
        /// product in inventory that is in stock.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PointOfSale_Load(object sender, EventArgs e)
        {

            loadButtons();
            setButtonLoc();
        }

        /// <summary>
        /// testInput() method is called when the button funcionality asks for user to input a quantity of a product
        /// to be sold. It uses recursion to continually open a new form until the user selects exit or inputs valid
        /// information. A VisualBasic InputBox was used as online research concluded there was no way to dynamically
        /// create an input form in C# (feedback would be appreciated). An alternate way could have been to create a
        /// custom input form.
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        private int testInput(Product test)
        {
            //create variables to hold the amount of a product to add to a sale and a boolean to signify if 
            // the amount is less than the amount in inventory.
            int qtyTodAdd = 0;
            bool available = false;   //Set to false until code determines that there are enough in stock

            //display a form and get user input. Display the quantity available in the window header.
                int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Product:" +
                    test.ID + " has " + test.Qty + " in stock.", "Enter Quantitiy", "1", 0, 0), out qtyTodAdd);
            
                if (qtyTodAdd <= test.Qty)
                    available = true;
            //if qtytoAdd is 0 then the user selected exit, cancel, clicked on the X or put 0 or a non interger in the input box.
            if (qtyTodAdd == 0)
            {
                return qtyTodAdd; //return 0, this will return 0 to all recursive calls and exit back to the form and no items
                                  // will be added to the list.
            }
            //User entered a number. check to see if the quantity is available.
            if (qtyTodAdd < 1 || available == false)
            return qtyTodAdd = testInput(test);  //User entered a number higher then what is available, open a new window and try again.
            else 
            return qtyTodAdd; // Return the amount to add.
        }

        /// <summary>
        /// loadButtons() creates a button or each item in inventory that has product in stock.
        /// </summary>
        private void loadButtons()
        {
            // Check each product to see if it has quantity greater than 0. Then create a button for it.
            foreach (Product temp in Form1.products)
            {
                if (temp.Qty > 0)
                {
                    //Variables to dynamically create a button and its click event.
                    Button newButton = new Button();
                    newButton.Text = "ID:" + temp.ID + "\n"+ temp.Name +"\n$" + temp.Price.ToString();
                    newButton.Size = new Size(75, 75);
                    newButton.Click += (se, ev) =>
                    {
                        //This checks to see what mode the POS form is in. 
                        if (addQuantityCheckBox.Checked) //This mode asks the user to input a qunatity to add.
                        {
                            int intIn = 0;              //Will hold the quantity to add
                            intIn = testInput(temp);    //Get user input
                            if (intIn > 0)                //If more than zero add the item to the list
                                newSale.Add(temp, intIn);
                            else return;

                        }
                        else                            //This mode adds 1 of the product to the list
                        {
                            newSale.Add(temp);
                        }
                        //Recreate the buttons as there may be items that are no longer available as they 
                        // where all added to the list to be sold.
                        removeButtons();              //Remove all the buttons
                        loadButtons();                //Create new buttons
                        setButtonLoc();               // Display them
                        UpdateAll();                  // update all the lists,labels and refresh the other forms.


                    };
                    //Add the button the list
                    buttons.Add(newButton);
                    //Add the button to the form.
                    this.Controls.Add(newButton);
                }
            }
        }
        /// <summary>
        /// UpdateAll() method calls the updateList() method to update the text in the Sale list,
        /// the UpdateLabels() method to update the price
        /// </summary>
        private void UpdateAll()
        {
            UpdateList();
            UpdateLabels();
            parent.refreshAll();
        }

        /// <summary>
        /// UpdateList() gets the id and price of each item that was added to the sale and adds it to the list
        /// </summary>
        private void UpdateList()
        {
            saleListBox.Items.Clear();
            for (int i = 0; i < newSale.NumbOfProd; i++)
            {
                saleListBox.Items.Add("ID:" + newSale.ID(i) + " $" + newSale.Price(i).ToString());
            }
        }
        /// <summary>
        /// refresh() is called from the main form whenever there is a change outside of the POS form. 
        /// This causes all the buttons, labels and list to reflect any changes made to the products.
        /// </summary>
        internal void refresh()
        {
         
            removeButtons();
            loadButtons();
            setButtonLoc();
            UpdateList();
            UpdateLabels();

        }
        /// <summary>
        /// UpdateLabels sets the total amount of all items in the sale to the totalLabel.
        /// </summary>
        private void UpdateLabels()
        {
            totalLabel.Text = newSale.Total.ToString("c");
        }

        /// <summary>
        /// setButtonLoc() method uses a list to iterate through each button and assign it a location.
        /// At the 5th button it begins a new row.
        /// </summary>
        private void setButtonLoc()
        {
            int rowCount = 0;


            int x = 10;
            int y = 10;
            foreach (Button temp in buttons)
            {
                temp.Location = new Point(x, y);

                x += 80;
                if (rowCount == 4)
                {
                    x = 10;
                    y += 80;
                    rowCount = 0;
                }
                else
                {
                    rowCount++;
                }
            }
        }

        /// <summary>
        /// removeButton_Click() removes an item from the sale and the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (saleListBox.SelectedIndex > -1)
            {
                newSale.Delete(saleListBox.SelectedIndex);
                saleListBox.Items.RemoveAt(saleListBox.SelectedIndex);
                removeButtons();
                loadButtons();
                setButtonLoc();
                UpdateAll();
            }
            else return;
        }
        
        /// <summary>
        /// Removes all the buttons from the form using a list of butons.
        /// </summary>
        private void removeButtons()
        {
            foreach (Button temp in buttons)
            {
                this.Controls.Remove(temp);
            }
            buttons.Clear();
        }
        /// <summary>
        /// receiptButton_Click is an event handler for the Print receipt button. It creates a text file
        /// that can be sent to a printer (printer connectivity to be added in the future). The text file 
        /// contains the date, the name of the store, an entry for each qty of a product and its price with
        /// total price of all items at the end.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void receiptButton_Click(object sender, EventArgs e)
        {
            // Create string to hold the date
            string date =  (DateTime.Today.ToString("dd-MM-yyyy") +"-" + 
                DateTime.Now.ToString("HH-mm-ss"));
            //Create strin got hold the filename of the receipt.
            string filename = date + ".txt";
            
            //Create a path object
            string sPath = filename;

            //Write all info to the file
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            SaveFile.WriteLine("Thank you for shopping at ");
            SaveFile.WriteLine( Form1.storeName + "!");
            SaveFile.WriteLine("");
            SaveFile.WriteLine("");
            SaveFile.WriteLine("Purchase date: " );
            SaveFile.WriteLine(date);
            SaveFile.WriteLine("");
            SaveFile.WriteLine("");
            foreach (var item in saleListBox.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }

                SaveFile.WriteLine("Total:" + totalLabel.Text);
                SaveFile.Close();

                MessageBox.Show("Printing Receipt!");
            //Call method to print txt file (to be implemented in future release).
        }
    }
}
