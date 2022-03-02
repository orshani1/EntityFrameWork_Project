using DigitalATM.DB;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss;

namespace DigitalATM.UI
{
    public partial class CreateSaving : UserControl
    {
        public DigitalATMContext context = new DigitalATMContext();
        public IUnitOfWork UnitOfWork { get; set; }
        public CreateSaving()
        {
            InitializeComponent();
            UnitOfWork = new UnitOfWork(context);
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
                UnitOfWork.Saving.CreateNewSaving(LoginMenu.thisAccount, Convert.ToInt32(amountNum.Value), nameTextBox.Text);
                ActionSaved();
                this.Dispose();
            }
        }

        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CreateSaving_Load(object sender, EventArgs e)
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
            var buttons = MessageBoxButtons.YesNoCancel;
            var results = MessageBox.Show(text, caption, buttons, icon);
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
