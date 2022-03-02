using DigitalATM.DB;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss;


namespace DigitalATM.UI
{
    public partial class HomePage : UserControl
    {
        public DigitalATMContext _context { get; set; } = new DigitalATMContext();
        public IUnitOfWork UnitOfWork { get; set; }
        public static bool ShowLoan { get; set; }
        public HomePage()
        {
            InitializeComponent();
            UnitOfWork = new UnitOfWork(_context);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        #region TextChanged,MouseEnter
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion
        #region ButtonsClicked Events
        private void button1_Click(object sender, EventArgs e)
        {
            ShowHidePanel(creditCardsSubMenu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowHidePanel(loansSubMenu);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ShowHidePanel(depositSubMenu);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ShowHidePanel(withdrawSubMenu);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            UnitOfWork.Cards.CreateAndReturnCreditCard(LoginMenu.thisAccount);
            var results = AreYouSureMessage("Order New Credit Card");
            if (results == false)
            {
                return;
            }
            else
            {

                var newCard = UnitOfWork.Cards.CreateAndReturnCreditCard(LoginMenu.thisAccount);
                ActionSaved();
                this.Dispose();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Remove Credit Card");
            if (results == false)
            {
                return;
            }
            else
            {
                UnitOfWork = new UnitOfWork(_context);
                var cardNum = int.Parse(labelCardNumber.Text);
                UnitOfWork.Cards.DeleteCreditCard(cardNum);
                MessageBox.Show("Saved");
                this.Dispose();
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Request New Loan");
            if (results == false)
            {
                return;
            }
            else
            {
                UnitOfWork.Loans.CreateNewLoan(LoginMenu.thisAccount, (int)loanAmountNumeric.Value, (int)loanDepositNumeric.Value);
                ActionSaved();
                this.Dispose();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

            var results = AreYouSureMessage("New Deposit");
            if (results == false)
            {
                return;
            }
            else
            {
               

                ActionSaved();
                UnitOfWork.Deposits.CreateNewDeposit(LoginMenu.thisAccount, (int)depositNumeric.Value);
                MessageBox.Show("Action Saved");
                this.Dispose();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("New Withdraw");
            if (results == false)
            {
                return;
            }
            else
            {

                ActionSaved();
                UnitOfWork.WithDraw.CreateNewWithDraw(LoginMenu.thisAccount, (int)withdrawNumeric.Value);
                this.Dispose();
            }

        }
        #endregion
        #region My Methods
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
        public void LoadAll()
        {

            var card = UnitOfWork.Cards.GetThisCard(LoginMenu.thisAccount);

            var count = UnitOfWork.Cards.GetThisUserCardsCount(LoginMenu.thisAccount);
            if (card != null)
            {

                labelCardNumber.Text = card.CardNumber.ToString();
                cardsCountLabel.Text = count.ToString();
                labelCVV.Text = card.CardCvv.ToString();
                loansSubMenu.Hide();
                creditCardsSubMenu.Hide();
                withdrawSubMenu.Hide();
                depositSubMenu.Hide();
                loanAmountLabel.Text = UnitOfWork.Loans.GetThisUserLoansAmountTotal(LoginMenu.thisAccount).ToString();
                depositNumlabel.Text = UnitOfWork.Loans.GetThisUserLoansDepositsTotal(LoginMenu.thisAccount).ToString();
                labelForBalance.Text = $"{UnitOfWork.Accounts.GetUserBalance(LoginMenu.thisAccount)}$";
            }
        }
        void ShowHidePanel(Panel panel)
        {
            if (panel.Visible)
                panel.Hide();
            else
            {
                panel.Show();
            }

        }
        #endregion

        #region MouseEVENTS
        private void loanAmountNumeric_ValueChanged(object sender, EventArgs e)
        {
            newLoanButton.Enabled = true;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Crimson;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Crimson;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.Crimson;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Transparent;
        }
        #endregion
    }
}
