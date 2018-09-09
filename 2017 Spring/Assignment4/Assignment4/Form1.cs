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
    /// Form1 is a windows program that is used to add,edit and view products in an Inventory and also displays
    /// a Point of Sale window.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form1() is a no argument constructor that initializes the form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
           
        }

        //Create BindingList objects to hold products and forms. The forms list is used to
        //update all the forms when there is a change.
        public static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<ManageStock> forms = new BindingList<ManageStock>();
        public static BindingList<PointOfSale> POSforms = new BindingList<PointOfSale>();

        //Variable to hold the name of the store.
        internal static readonly string storeName = "Test Store at Location:Test";

        /// <summary>
        /// Form1_Load adds some dummy products for evaluation and testing purposes when the form
        /// is initialized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
           
            products.Add(new Product("1000", "1Server", "Really Fast Server", 10000, 20));
            products.Add(new Product("2000", "2Server", "Really Fast Server", 10000, 20));
            products.Add(new Product("3000", "3Server", "Really Fast Server", 10000, 20));
            products.Add(new Product("4000", "4Server", "Really Fast Server", 10000, 0));
            products.Add(new Product("5000", "4Server", "Really Fast Server", 23123, 20));
            products.Add(new Product("6000", "4Server", "Really Fast Server", 6654, 20));
            products.Add(new Product("7000", "4Server", "Really Fast Server", 8900, 20));
            products.Add(new Product("8000", "4Server", "Really Fast Server", 5600, 20));
            products.Add(new Product("9000", "4Server", "Really Fast Server", 1230, 20));
            products.Add(new Product("10000", "4Server", "Really Fast Server", 1000, 20));
        }
        /// <summary>
        /// ManageStockForm() is a method used to create a new form that displays current inventory and
        /// allows the user to add or edit products. It can only be called from this form. 
        /// Future functionality would implement checks to ensure there is only one form allowed at a time.
        /// </summary>
        private void ManageStockForm()
        {
            ManageStock form = new ManageStock(this);
            form.MdiParent = this;
            forms.Add(form);
            form.Show();
        }

        /// <summary>
        /// addProductForm() creates a form that allows the users to add a new product. It can be called from
        /// other forms. Future functionality would implement checks to ensure there is only one form allowed at a time.
        /// </summary>
        internal void addProductForm()
        {
            AddProdForm form = new AddProdForm(this);
            form.MdiParent = this;
            form.Show();

        }
        /// <summary>
        /// editProductForm() creates a form that allows the user to edit an existing product. It can be 
        /// from other forms. 
        /// Future functionality would implement checks to ensure there is only one form allowed at a time.
        /// </summary>
        internal void editProductForm()
        {
            EditProductForm form = new EditProductForm(this);
            form.MdiParent = this;
            form.Show();

        }
        /// <summary>
        /// restockForm() displays a form with the products that are below 5 in quanity.
        /// Future functionality would implement checks to ensure there is only one form allowed at a time and allow
        /// the user to set a new threshold.
        /// </summary>
        private void restockForm()
        {
            RestockForm form = new RestockForm();
            form.MdiParent = this;
            form.Show();

        }

        /// <summary>
        /// editProductForm() is an overloaded method that creates a form that allows the user to edit an 
        /// existing product. It receives an integer that corresponds to the index of an item selected in a
        /// datagrid. It can be called from other forms. 
        /// Future functionality would implement checks to ensure there is only one form allowed at a time.
        internal void editProductForm(int rowIndex)
        {
            EditProductForm form = new EditProductForm(rowIndex,this);
            form.MdiParent = this;
            form.Show();
        }
        /// <summary>
        /// pointOfSaleForm() creates a form that can be used to conduct a sale of items that are in 
        /// stock. 
        ///  Future functionality would implement checks to ensure there is only one form allowed at a time.
        /// </summary>
        public void pointOfSaleForm()
        {
            PointOfSale form = new PointOfSale(this);
            form.MdiParent = this;
            POSforms.Add(form);
            form.Show();

        }


        /// <summary>
        /// manageStockToolStripMenuItem_Click() is an event handler that creates a ManageStock form when
        /// the user clicks on the menu item by calling the ManageStockForm() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manageStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStockForm();
        }

        /// <summary>
        /// addProductToolStripMenuItem_Click is an event handler that creates a AddProduct form when
        /// the user clicks on the menu item by calling the addProductForm() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProductForm();


        }

        /// <summary>
        /// editProductToolStripMenuItem_Click is an event handler that creates a EditProduct form when
        /// the user clicks on the menu item by calling the editProductForm() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            editProductForm();


        }

        /// <summary>
        /// restockProductsToolStripMenuItem_Click is an event handler that creates a Restock form when
        /// the user clicks on the menu item by calling the restockForm() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restockProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restockForm();
            
        }
        /// <summary>
        /// exitToolStripMenuItem_Click is an event handler that closes the program when the users selects exit
        /// from the menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// pOSToolStripMenuItem_Click is an event handler that creates a PointOfSale form when
        /// the user clicks on the menu item by calling the pointOfSaleForm() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pointOfSaleForm();
        }


        /// <summary>
        /// resfreshAll() method is used to update all the ManageStock and PointOfSale forms when there is a 
        /// change in the products. It does this by going through each form in a list and calling its refresh() 
        /// method.
        /// </summary>
        public void refreshAll()
        {
            foreach (ManageStock temp in forms)
            {
                temp.refresh();
            }

            foreach (PointOfSale temp in POSforms)
            {
                temp.refresh();
            }

        }
    }
}
