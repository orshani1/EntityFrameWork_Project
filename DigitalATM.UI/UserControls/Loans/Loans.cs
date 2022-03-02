using DigitalATM.DB;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
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
    public partial class Loans : UserControl
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public DigitalATMContext context { get; set; } = new DigitalATMContext();
        public Loans()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Request New Loan");
            if (results == false)
            {
                return;
            }
            else
            {
                UnitOfWork = new UnitOfWork(context);               
                var amount = int.Parse(amountTextBox.Text);
                var depositAmount = int.Parse(depositAmountTextBox.Text);
                UnitOfWork.Loans.CreateNewLoan(LoginMenu.thisAccount, startDateTimePicker2.Value, endDateTimePicker1.Value, amount, depositAmount);
                UnitOfWork.Accounts.CheckAccount(LoginMenu.thisAccount);    
                ActionSaved();
                this.Dispose();

            }

        }

        private void Loans_Load(object sender, EventArgs e)
        {
            startDateTimePicker2.MinDate = DateTime.Now;
        }

        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region MyMethods
        bool AreYouSureMessage(string caption)
        {

            var text = "Are you Sure You want to complete this action ? ";
            var icon = MessageBoxIcon.Question;
            var buttons = MessageBoxButtons.YesNoCancel;
            var results = MessageBox.Show(text, caption, buttons, icon);
            if (results == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void ActionSaved()
        {
            var caption = "Actions Saved";
            var text = "Your'e Action as Being executed\nThank You";
            var icon = MessageBoxIcon.Question;
            var buttons = MessageBoxButtons.YesNoCancel;
            var results = MessageBox.Show(text, caption, buttons, icon);
        }
        #endregion

        #region Styling
        private void returnPicBox_MouseEnter(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Crimson;
        }

        private void returnPicBox_MouseLeave(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;

        } 
        #endregion
    }
}
