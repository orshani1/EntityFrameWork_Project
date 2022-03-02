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
    public partial class CardSettings : UserControl
    {
        public DigitalATMContext context = new DigitalATMContext();
        IUnitOfWork unitOfWork;
        public CardSettings()
        {
            unitOfWork = new UnitOfWork(context);
            InitializeComponent();
        }

        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CardSettings_Load(object sender, EventArgs e)
        {
         
            unitOfWork = new UnitOfWork(context);
            comboBox1.DataSource = unitOfWork.Cards.GetCards();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CommitChanges();
        }

        private void deleteCardButton_Click(object sender, EventArgs e)
        {
            

            var results = AreYouSureMessage("Pay Loan");
            if (results == false)
            {
                return;
            }
            else
            {
                unitOfWork = new UnitOfWork(context);
                var cardNum = int.Parse(cardnumberlabel.Text);
                unitOfWork.Cards.DeleteCreditCard(cardNum);
                ActionSaved();
                this.Dispose();
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
        void CommitChanges()
        {

            var cardId = Convert.ToInt32(comboBox1.SelectedItem);
            var card = unitOfWork.Cards.GetThisCard(cardId);
            labelForId.Text = card.AccountId.ToString();
            cardCcvLabel.Text = card.CardCvv.ToString();
            cardnumberlabel.Text = card.CardNumber.ToString();
            dateLabel.Text = card.CardExpiredDate.ToString();
            holderLabel.Text = card.CardHolder;
            groupBox1.Visible = true;
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

        private void deleteCardButton_MouseEnter(object sender, EventArgs e)
        {
            deleteCardButton.BackColor = Color.Crimson;
        }

        private void deleteCardButton_MouseLeave(object sender, EventArgs e)
        {
            deleteCardButton.BackColor = Color.Transparent;
        } 
        #endregion
    }
}
