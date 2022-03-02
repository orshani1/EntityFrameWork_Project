using DigitalATM.DB.Modelss;
using DigitalATM.DB;
using System.Data;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;

namespace DigitalATM.UI
{
    public partial class RepayLoanUC : UserControl
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public DigitalATMContext context { get; set; } = new DigitalATMContext();
        public RepayLoanUC()
        {
            InitializeComponent();
        }

        private void RepayLoanUC_Load(object sender, EventArgs e)
        {
            using (var db = new DigitalATMContext())
            {
                comboBox1.DataSource = db.Loans.Where(l => l.AccountId == LoginMenu.thisAccount.AccountId).
                Select(l => l.Id).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Pay Loan");
            if (results == false)
            {
                return;
            }
            else
            {

                using (var db = new DigitalATMContext())
                {
                    UnitOfWork = new UnitOfWork(context);
                    var loan = db.Loans.Where(l => l.Id == Convert.ToInt32(comboBox1.SelectedItem)).
                          Select(l => l).FirstOrDefault();
                    UnitOfWork.Loans.PayLoan(LoginMenu.thisAccount, loan);
                    ActionSaved();
                }
            }
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

        #region MouseEVENTS
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;

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
    }
}
