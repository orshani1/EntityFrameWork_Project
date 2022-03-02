using DigitalATM.DB;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss;

using System.Data;

namespace DigitalATM.UI
{
    public partial class DepositAndWithrawSaving : UserControl
    {
        public DigitalATMContext _context { get; set; } = new DigitalATMContext();
        public IUnitOfWork UnitOfWork { get; set; }
        public DepositAndWithrawSaving()
        {

            InitializeComponent();
            UnitOfWork = new UnitOfWork(_context);
        }

        private void DepositAndWithrawSaving_Load(object sender, EventArgs e)
        {
            MyLoad();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Deposit to Existing Saving");
            if (results == false)
            {
                return;
            }
            else
            {
                ActionSaved();
                MakeDeposit();

            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Withdraw From Saving");
            if (results == false)
            {
                return;
            }
            else
            {

                ActionSaved();
                MakeWithdraw();
            }
        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CommitChange();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

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
            var buttons = MessageBoxButtons.OK;
            var results = MessageBox.Show(text, caption, buttons, icon);
        }
        void CommitChange()
        {
            var saving = UnitOfWork.Saving.GetSaving(comboBox1.SelectedValue.ToString());
            savingAmountLabel.Text = saving.Amount.ToString();
            savingNameLabel.Text = saving.SaveName;
            savingStartDateLanbel.Text = saving.StartDate.Date.ToString();
        }

        void MakeWithdraw()
        {
            if (comboBox1.SelectedValue != null)
            {

                using (var db = new DigitalATMContext())
                {
                    var saving = db.Savings.Where(c => c.AccountId == LoginMenu.thisAccount.AccountId && c.SaveName == comboBox1.SelectedItem).
                        Select(c => c).FirstOrDefault();
                    db.Savings.Where(s => s.Id == saving.Id).
                        Select(s => s).FirstOrDefault();
                    AccountAction action = new AccountAction()
                    {
                        AccountId = LoginMenu.thisAccount.AccountId,
                        Amount = saving.Amount,
                        ActionId = saving.Id,
                        Date = DateTime.Now.Date,
                        Description = $"Withdraw From Saving {saving.SaveName}"
                    };
                    if (saving.Amount == 0 || allCheckBox.Checked == true)
                    {
                        db.Remove(saving);
                        LoginMenu.thisAccount.Balance += saving.Amount;
                        db.AccountActions.Add(action);
                        db.SaveChanges();
                        this.Dispose();
                    }
                    else
                    {
                        saving.Amount -= (int)numericUpDown1.Value;
                        LoginMenu.thisAccount.Balance += saving.Amount;
                        db.AccountActions.Add(action);
                        db.SaveChanges();
                        this.Dispose();
                    }
                }
            }
        }
        void MyLoad()
        {

            using (var db = new DigitalATMContext())
            {
                comboBox1.DataSource = db.Savings.Where(s => s.AccountId == LoginMenu.thisAccount.AccountId).
                    Select(s => s.SaveName).ToList();

            }
            if (comboBox1.SelectedValue != null)
            {

                var saving = UnitOfWork.Saving.GetSaving(comboBox1.SelectedValue.ToString());
                savingAmountLabel.Text = saving.Amount.ToString();
                savingNameLabel.Text = saving.SaveName;
                savingStartDateLanbel.Text = saving.StartDate.Date.ToString();
            }
        }
        void MakeDeposit()
        {
            if (comboBox1.SelectedValue != null)
            {

                using (var db = new DigitalATMContext())
                {
                    var saving = db.Savings.Where(s => s.AccountId == LoginMenu.thisAccount.AccountId && s.SaveName == comboBox1.SelectedValue).
                        Select(s => s).FirstOrDefault();
                    saving.Amount += (int)numericUpDown1.Value;
                    AccountAction action = new AccountAction()
                    {
                        AccountId = LoginMenu.thisAccount.AccountId,
                        Amount = (int)numericUpDown1.Value,
                        ActionId = saving.Id,
                        Date = DateTime.Now.Date,
                        Description = $"Deposit To Saving {saving.SaveName}"
                    };
                    LoginMenu.thisAccount.Balance -= (int)numericUpDown1.Value;

                    db.AccountActions.Add(action);

                    db.SaveChanges();
                    MessageBox.Show("Amount Deposited");
                    this.Dispose();


                }
            }
        }
        #endregion

        #region MouseEvents
        private void returnPicBox_MouseEnter(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Crimson;
        }

        private void returnPicBox_MouseLeave(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Transparent;
        }

        private void withdrawButton_MouseEnter(object sender, EventArgs e)
        {
            withdrawButton.BackColor = Color.Crimson;
        }

        private void withdrawButton_MouseLeave(object sender, EventArgs e)
        {
            withdrawButton.BackColor = Color.Transparent;
        }

        private void depositButton_MouseEnter(object sender, EventArgs e)
        {
            depositButton.BackColor = Color.Crimson;
        }

        private void depositButton_MouseLeave(object sender, EventArgs e)
        {
            depositButton.BackColor = Color.Transparent;
        } 
        #endregion
    }
}