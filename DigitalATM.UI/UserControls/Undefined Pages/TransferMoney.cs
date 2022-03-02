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
    public partial class TransferMoney : UserControl
    {
        public TransferMoney()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TransferMoney_Load(object sender, EventArgs e)
        {
            MyLoad();
        }


        private void amountLabel_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private void amountLabel_Click(object sender, EventArgs e)
        {
            amountTextBox.Clear();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("New Transfer");
            if (results == false)
            {
                return;
            }
            else
            {
                if (!String.IsNullOrEmpty(amountTextBox.Text))
                {

                    if (LoginMenu.thisAccount.Balance < Convert.ToInt32(amountTextBox.Text))
                    {
                        MessageBox.Show("Amount to High for Balance");
                    }
                    else
                    {


                        if (dateTimePicker1.Value.Date != DateTime.Today.Date)
                        {

                        }

                        else
                        {
                            SaveTransferRequest();
                        }
                    }
                }
            }
        }




        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;

        }


        #region PictureBox MouseLeave and Enter Events
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

        }


        private void returnPicBox_MouseEnter(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Crimson;

        }

        private void returnPicBox_MouseLeave(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Transparent;

        }
        #endregion




        #region PicturesClick Event
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void returnPicBox_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion




        #region My Methods
        private int ReturnedBankNumber(ListBox clientListBox)
        {

            var bankNum = string.Empty;
            for (int i = 0; i < clientListBox.SelectedItem.ToString().Length; i++)
            {
                if (!char.IsDigit(clientListBox.SelectedItem.ToString()[i]))
                {
                    clientListBox.SelectedItem.ToString().Remove(i);
                }
                else
                {
                    bankNum += clientListBox.SelectedItem.ToString()[i];
                }
            }
            return Convert.ToInt32(bankNum);
        }
        private void SaveTransferRequest()
        {
            using (var db = new DigitalATMContext())
            {
                var clients = db.Accounts.Where(c => c.UserName != LoginMenu.thisAccount.UserName)
               .Select(c => c.BankAccNumber).ToList();

                var bankNum = ReturnedBankNumber(clientListBox);
                DateTime date = new DateTime();
                date = DateTime.Now;
                if (dateTimePicker1.Value.Month == date.Month && dateTimePicker1.Value.Day == date.Day && dateTimePicker1.Value.Year == date.Year)
                {
                    var sendingAccount = db.Accounts.Where(a => a.BankAccNumber == LoginMenu.thisAccount.BankAccNumber).
                         Select(a => a).FirstOrDefault();
                    var recivingAccount = db.Accounts.Where(a => a.BankAccNumber == bankNum).Select(a => a).FirstOrDefault();
                    recivingAccount.Balance += Convert.ToInt32(amountTextBox.Text);
                    sendingAccount.Balance -= Convert.ToInt32(amountTextBox.Text);
                    LoginMenu.thisAccount.Balance = sendingAccount.Balance;
                    Transfer transfer = new Transfer()
                    {

                        Amount = int.Parse(amountTextBox.Text),
                        RecivingAccountId = recivingAccount.AccountId,
                        SendingAccountId = sendingAccount.AccountId,
                        TransferDate = dateTimePicker1.Value,
                        AccountId = sendingAccount.AccountId,

                    };
                    recivingAccount.Transfers.Add(transfer);
                    sendingAccount.Transfers.Add(transfer);
                    db.Transfers.Add(transfer);
                    db.SaveChanges();
                    AccountAction action = new AccountAction()
                    {
                        Account = recivingAccount,
                        AccountId = sendingAccount.AccountId,

                        Amount = transfer.Amount,
                        Date = dateTimePicker1.Value,
                        Description = $"Transfer From BankNumber  {sendingAccount.BankAccNumber + " " + "To " + " " + sendingAccount.BankAccNumber}"

                    };
                    AccountAction action2 = new AccountAction()
                    {
                        Account = sendingAccount,
                        AccountId = sendingAccount.AccountId,
                        Amount = transfer.Amount,
                        Date = dateTimePicker1.Value,
                        Description = $"Transfer To BankNumber {recivingAccount.BankAccNumber + " " + "From" + " " + recivingAccount.BankAccNumber}"

                    };
                    action.ActionId = transfer.Id;
                    action2.ActionId = transfer.Id;
                    sendingAccount.AccountActions.Add(action2);
                    recivingAccount.AccountActions.Add(action);

                    db.SaveChanges();
                    MessageBox.Show("Action Saved");
                    this.Hide();

                }
            }

        }
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
        void MyLoad()
        {
            using (var db = new DigitalATMContext())
            {
                var clients = db.Accounts.Where(c => c.UserName != LoginMenu.thisAccount.UserName)
                     .Select(c => c.Client.FirstName + " " + c.Client.LastName + " " + c.BankAccNumber).ToList();
                clientListBox.DataSource = clients;
            }
            blanceLabel.Text = LoginMenu.thisAccount.Balance.ToString();
            accountNumLabel.Text = LoginMenu.thisAccount.BankAccNumber.ToString();
            dateTimePicker1.MinDate = DateTime.Today;
        }
        #endregion

    }
}
