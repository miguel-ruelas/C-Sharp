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
    /// ManageStock is a form that is used to view, add and edit products in an inventory.
    /// </summary>
    public partial class ManageStock : Form
    {
        //variables to hold the main form (used to call the refreshAll() method when there is a change) and
        // an integer that corresponds to the index in the datagrid of an item to be edited.
        private Form1 parent;
        private int toBeEdited;

        /// <summary>
        /// ManageStock() is a no argument constructor that initializes the form.
        /// </summary>
        public ManageStock()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// ManageStock() is an overloaded constructor that accpets a Form1 object which represents the main form.
        /// It assigns it to a local variable and then calls the no argument constructor to initialize the form.
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public ManageStock(Form1 parent) : this()
        {
            this.parent = parent;
            
        }
        /// <summary>
        /// ManageStock_Load() sets up the form by setting up the data grid which displays the products in 
        /// inventory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageStock_Load(object sender, EventArgs e)
        {
            //Do not create columns
            inventoryGridView.AutoGenerateColumns = false;
            inventoryGridView.AutoSize = true;
            inventoryGridView.DataSource = Form1.products;
            
            //Manually create the columns needed and add them to datagrid
            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            DataGridViewColumn priceColumn = new DataGridViewTextBoxColumn();
            DataGridViewColumn qtyColumn = new DataGridViewTextBoxColumn();

            idColumn.Name = "Product ID";
            idColumn.DataPropertyName = "ID";

            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";

            priceColumn.Name = "Price";
            priceColumn.DataPropertyName = "Price";

            qtyColumn.Name = "QTY";
            qtyColumn.DataPropertyName = "QTY";

            inventoryGridView.Columns.Add(idColumn);
            inventoryGridView.Columns.Add(nameColumn);
            inventoryGridView.Columns.Add(priceColumn);
            inventoryGridView.Columns.Add(qtyColumn);  
        }

        /// <summary>
        /// closeButton_Click is an event handler for the exit button. It closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// addInventoryButton_Click is an event handler for the add button. It calls the main forms
        /// addProductForm() method to create an addProdForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addInventoryButton_Click(object sender, EventArgs e)
        {
            parent.addProductForm();
            
        }

        /// <summary>
        /// editProductButton_Click is an event handler for the edit button. It calls the main form's
        /// editProductForm() method to create and EditProdctForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editProductButton_Click(object sender, EventArgs e)
        {

            parent.editProductForm();
            
        }

        /// <summary>
        /// inventoryGridView_CellClick is an event handler that calls the main forms overloaded editProductForm()
        /// method which accepts an integer that corresponds to the index of the item the user selected to edit from
        /// the data grid. The editProductForm() method then creates a form and uses the index to populate the text
        /// box fields for the the user to edit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inventoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            toBeEdited = e.RowIndex;
            parent.editProductForm(e.RowIndex);
            

        }

        /// <summary>
        /// refresh() is a method that is used by the main form to update the data grid in this form.
        /// </summary>
        public void refresh()
        {
            inventoryGridView.Refresh();
        }
    }
}
