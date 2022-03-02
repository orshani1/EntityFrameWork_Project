using DigitalATM.DB.Modelss;

using System.Data;
using DigitalATM.DB;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;

namespace DigitalATM.UI
{
    public partial class DisabelCard : UserControl
    {
        public DigitalATMContext context = new DigitalATMContext();
        public IUnitOfWork UnitOfWork { get; set; }
        public DisabelCard()
        {
            InitializeComponent();
        }

        private void DisabelCard_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            using (var db = new DigitalATMContext())
            {
                comboBox1.DataSource = db.CreditCards.Where(c => c.AccountId == LoginMenu.thisAccount.AccountId).
                    Select(c => c.CardNumber).ToList();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Delete Credit Card");
            if (results == false)
            {
                return;
            }
            else
            {
                UnitOfWork = new UnitOfWork(context);
                UnitOfWork.Cards.DeleteCreditCard(Convert.ToInt32(comboBox1.SelectedItem));
                ActionSaved();
                this.Dispose();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Crerate New Card");
            if (results == false)
            {
                return;
            }
            else
            {
                UnitOfWork = new UnitOfWork(context);
                if (LoginMenu.thisAccount != null)
                {
                    UnitOfWork.Cards.CreateAndReturnCreditCard(LoginMenu.thisAccount);
                    ActionSaved();
                    this.Dispose();
                    this.Hide();
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
        private void returnPicBox_MouseEnter(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Crimson;
        }

        private void returnPicBox_MouseLeave(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Transparent;

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Crimson;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
