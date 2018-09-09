using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsumeBookFinderService
{
    public partial class Form1 : Form
    {
        localhost.BookFinderServiceClient client = new localhost.BookFinderServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetComplete_Click(object sender, EventArgs e)
        {
            lbxResults.Items.Clear();
            
            
            foreach (localhost.Book b in client.GetBookList(txtSort.Text))
            {
                lbxResults.Items.Add(client.ToBookString(b));
            }
           
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lbxResults.Items.Clear();
            lbxResults.Items.Add(client.ToBookString(client.FindBook(txtPartial.Text)));   
        }
    }
}
