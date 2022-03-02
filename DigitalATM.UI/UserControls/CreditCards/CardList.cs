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
    public partial class CardList : UserControl
    {
        public CardList()
        {
            InitializeComponent();
        }

        private void CardList_Load(object sender, EventArgs e)
        {
            using (var db = new DigitalATMContext())
            {
                dataGridView1.DataSource = db.CreditCards.Where(c => c.AccountId == LoginMenu.thisAccount.AccountId).
                    Select(c => c).ToList();
         
            }
        }

        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString()=="Expire Date")
            {
                SortBy("Expire Date");
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
                if (sortTerm == "Expire Date")
                {
                    dataGridView1.DataSource = db.CreditCards.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                        Select(a => a).OrderBy(a => a.CardExpiredDate).ToList();
                }
                else
                {
                    dataGridView1.DataSource = db.CreditCards.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                        Select(a => a).OrderBy(a => a.CardId).ToList();
                }
            }
        } //Method To Sort the list box 
        #endregion
    }
}
