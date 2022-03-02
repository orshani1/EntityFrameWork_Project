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
    public partial class LoansListUC : UserControl
    {
        public LoansListUC()
        {
            InitializeComponent();
        }

        private void LoansListUC_Load(object sender, EventArgs e)
        {
            using (var db = new DigitalATMContext())
            {
                var clientLoans = db.Loans.Where(l => l.AccountId == LoginMenu.thisAccount.AccountId).ToList();
                dataGridView1.DataSource = clientLoans;
            }
        }

        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        #region MyMethods
        public void SortBy(string sortTerm)
        {
            using (var db = new DigitalATMContext())
            {
                if (sortTerm == "End Date")
                {
                    dataGridView1.DataSource = db.Loans.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                        Select(a => a).OrderBy(a => a.EndDate).ToList();
                }
                else if (sortTerm == "Amount")
                {
                    dataGridView1.DataSource = db.Loans.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                       Select(a => a).OrderBy(a => a.Amount).ToList();
                }
                else if (sortTerm == "Start Date")
                {
                    dataGridView1.DataSource = db.Loans.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                     Select(a => a).OrderBy(a => a.StartDate).ToList();
                }
                else
                {
                    dataGridView1.DataSource = db.Loans.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                        Select(a => a).OrderBy(a => a.Id).ToList();
                }
            }
        } //Method To Sort the list box 
        #endregion

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "End Date")
            {
                SortBy("End Date");
            }
            else if (listBox1.SelectedItem.ToString() == "Amount")
            {
                SortBy("Amount");
            }
            else if (listBox1.SelectedItem.ToString() == "Start Date")
            {
                SortBy("Start Date");
            }

            else
            {
                SortBy("Id");
            }
        }
    }
}
