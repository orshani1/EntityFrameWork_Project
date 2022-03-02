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
    public partial class SavingList : UserControl
    {
        public SavingList()
        {
            InitializeComponent();
        }

        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SavingList_Load(object sender, EventArgs e)
        {
            using (var db = new DigitalATMContext())
            {
                dataGridView1.DataSource = db.Savings.Where(s => s.AccountId == LoginMenu.thisAccount.AccountId).
                    Select(s => s).ToList();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Name")
            {
                SortBy("Name");
            }
            else if (listBox1.SelectedItem.ToString() == "Amount")
            {
                SortBy("Amount");
            }
            else if (listBox1.SelectedItem.ToString() == "Date")
            {
                SortBy("Date");
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
                    dataGridView1.DataSource = db.Savings.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                        Select(a => a).OrderBy(a => a.SaveName).ToList();
                }
                else if (sortTerm == "Amount")
                {
                    dataGridView1.DataSource = db.Savings.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                       Select(a => a).OrderBy(a => a.Amount).ToList();
                }
                else if (sortTerm == "Date")
                {
                    dataGridView1.DataSource = db.Savings.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                     Select(a => a).OrderBy(a => a.StartDate).ToList();
                }
                else
                {
                    dataGridView1.DataSource = db.Savings.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                        Select(a => a).OrderBy(a => a.Id).ToList();
                }
            }
        } //Method To Sort the list box 
        #endregion
    }
}
