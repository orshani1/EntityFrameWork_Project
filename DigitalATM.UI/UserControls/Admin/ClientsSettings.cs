using DigitalATM.DB.Modelss;
using System.Data;
using DigitalATM.DB;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.UI
{
    public partial class ClientsSettings : UserControl
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public DigitalATMContext _context { get; set; } = new DigitalATMContext();  
        public ClientsSettings()
        {
            InitializeComponent();
        }

        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           

        }

        private void ClientsSettings_Load(object sender, EventArgs e)
        {
            using (var db = new DigitalATMContext())
            {

                comboBox1.DataSource = db.Accounts.Select(a => a.BankAccNumber).ToList();


            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeCommit(sender,e);
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Delete Account");
            if (results == false)
            {
                return;
            }
            else
            {
                IGenericRepository<Account> genericRepository = new GenericRepository<Account>(new DigitalATMContext());
                
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Save Clients Changes");
            if (results == false)
            {
                return;
            }
            else
            {
                SaveChanges();
            }
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
        void SaveChanges()
        {
            using (var db = new DigitalATMContext())
            {

                var account = db.Accounts.Where(a => a.BankAccNumber == Convert.ToInt64(comboBox1.SelectedValue)).
                        Select(a => a).FirstOrDefault();
                var balance = int.Parse(balanceTextBox.Text);
                var bankNum = int.Parse(accountNumTextBox.Text);


                UnitOfWork = new UnitOfWork(_context);
                UnitOfWork.Clients.SaveChanges(account, balance, bankNum, passwordTextBox.Text, usernameTextBox.Text, emailTextBox.Text, fullNameTextBox.Text);
                MessageBox.Show("action saved");
                this.Dispose();

            }
        }
        void DeleteAccount()
        {
            using (var db = new DigitalATMContext())
            {
                UnitOfWork = new UnitOfWork(_context);

                var account = db.Accounts.Where(a => a.BankAccNumber == Convert.ToInt64(comboBox1.SelectedValue)).
                    Select(a => a).FirstOrDefault();
                IGenericRepository<Account> genericRepository = new GenericRepository<Account>(new DigitalATMContext());
                genericRepository.Remove(account);
                this.Dispose();

            }
        }
        void ChangeCommit(object sender, EventArgs e)
        {
            rawInfoGroupBox.Visible = true;
            using (var db = new DigitalATMContext())
            {
///Extract 
                var account = db.Accounts.Where(a => a.BankAccNumber == Convert.ToInt64(comboBox1.SelectedValue)).
                    Select(a => a).FirstOrDefault();
                var client = db.Clients.Where(c => c.ClientId == account.ClientId).
                    Select(a => a).FirstOrDefault();
                var bank = db.Banks.Where(b => b.BankId == account.BankId).
                    Select(b => b).FirstOrDefault();
                var loans = db.Loans.Where(l => l.AccountId == account.AccountId).
                    Select(l => l).ToList();
                var saving = db.Savings.Where(s => s.AccountId == account.AccountId).
                    Select(s => s).ToList();
                var CreditCard = db.CreditCards.Where(c => c.AccountId == account.AccountId).
                    Select(c => c).ToList();

                if (account == null)
                {

                    comboBox1_SelectionChangeCommitted(sender, e);//Recursive
                }

                accountNumTextBox.Text = account.BankAccNumber.ToString();
                balanceTextBox.Text = account.Balance.ToString();
                fullNameTextBox.Text = client.FirstName + " " + client.LastName;
                usernameTextBox.Text = account.UserName;
                passwordTextBox.Text = account.Password;
                emailTextBox.Text = client.Email;
                adressLabel.Text = $"Adress : {client.Adress + "," + client.City}";
                bankNameLabel.Text = $"Bank : {bank.BankName}";
                creditCardsLabel.Text = $"Credit Cards : {CreditCard.Count.ToString()}";
                loansLabel.Text = $"Loans : {loans.Count.ToString()}";
                savingLabel.Text = $"Savings : {saving.Count.ToString()}";
                phoneNumberLabel.Text = $"Phone number : {client.PhoneNumber.ToString()}";




            }
        }
        #endregion
        #region MouseEVENTS
        private void returnPicBox_MouseEnter(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Crimson;
        }
        private void returnPicBox_MouseLeave(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Transparent;
        }

        private void deleteAccountButton_MouseEnter(object sender, EventArgs e)
        {
            deleteAccountButton.BackColor = Color.Crimson;
        }

        private void deleteAccountButton_MouseLeave(object sender, EventArgs e)
        {
            deleteAccountButton.BackColor = Color.Transparent;
        }

        private void saveChangesButton_MouseEnter(object sender, EventArgs e)
        {
            saveChangesButton.BackColor = Color.Crimson;
        }

        private void saveChangesButton_MouseLeave(object sender, EventArgs e)
        {
            saveChangesButton.BackColor = Color.Transparent;
        } 
        #endregion
    }
}
