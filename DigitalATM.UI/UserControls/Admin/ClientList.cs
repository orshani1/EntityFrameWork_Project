using DigitalATM.DB.Modelss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalATM.UI
{
    public partial class ClientList : UserControl
    {
        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            using (var db = new DigitalATMContext())
            {
                dataGridView1.DataSource = db.Clients.Select(c => c).ToList();
            }
        }

        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Name")
            {
                SortBy("Name");
            }
            else if (listBox1.SelectedItem.ToString() == "Balance")
            {
                SortBy("Balance");
            }
            else if (listBox1.SelectedItem.ToString() == "Date")
            {
                SortBy("CreditCards");
            }
            else
            {
                SortBy("Id");
            }
        }
        #region MyMethods
        public void SortBy(string sortTerm)
        {
            using (var db = new DigitalATMContext())
            {
                if (sortTerm == "Name")
                {
                    dataGridView1.DataSource = db.Clients.
                        Select(a => a).OrderBy(a => a.FirstName + " " + a.LastName).ToList();
                }
                else if (sortTerm == "Balance")
                {
                    dataGridView1.DataSource = db.Accounts.
                       Select(a => a).OrderByDescending(a => a.Balance).ToList();
                }
                else if (sortTerm == "CreditCards")
                {
                    dataGridView1.DataSource = db.CreditCards.
                     Select(a => a).OrderBy(a => a).ToList().Count;
                }
                else
                {
                    dataGridView1.DataSource = db.Accounts.
                        Select(a => a).OrderBy(a => a.AccountId).ToList();
                }
            }
        } //Method To Sort the list box 
        #endregion
    }
}
