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
    /// <summary>
    /// Shows all the properties that have been added
    /// </summary>
    public partial class Report : Form
    {
        List<Property> prop;
        public Report(List<Property> property)
        {
            prop = property;
            InitializeComponent();
        }
        /// <summary>
        /// Add all the properties to the listbox on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Report_Load(object sender, EventArgs e)
        {
            foreach (Property p in prop)
            {
                propertyListBox.Items.Add(p.ToString());
                
            }
        }
        /// <summary>
        /// close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
