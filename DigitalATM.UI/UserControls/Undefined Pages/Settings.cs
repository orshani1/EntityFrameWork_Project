using DigitalATM.Logic;
using DigitalATM.DB;
using DigitalATM.DB.Modelss;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;

namespace DigitalATM.UI
{
    public partial class Settings : UserControl
    {
        public DigitalATMContext context = new DigitalATMContext();
        IUnitOfWork unitOfWork;
        public Settings()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork(context);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (emailCheckBox.Checked)
            {
                emailTextBox.Enabled = true;
            }
            else
            {
                emailTextBox.Enabled = false;
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void phoneNumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (phoneNumCheckBox.Checked)
            {
                phoneNumberTextBox.Enabled = true;
            }
            else
            {
                phoneNumberTextBox.Enabled = false;
            }
        }
        #region Enabling Buttons Events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            finalUpdateAdressButton.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            finalUpdateAdressButton.Enabled = true;

        }
        private void newPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            changePasswordFinalButton.Enabled = true;
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            changePasswordFinalButton.Enabled = true;

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            changeEmailButton.Enabled = true;
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            changeEmailButton.Enabled = true;

        } 
        #endregion

        #region ShowHide Menus
        private void updatePersonalDetailsButton_Click(object sender, EventArgs e)
        {
            ShowHidePanel(personalDetailsSubMenuPanel);
        }

        private void updateAdressSubMenuButton_Click(object sender, EventArgs e)
        {
            ShowHidePanel(updateAdressSubMenuPanel);
        }

        private void updateEmailOrPhoneButton_Click(object sender, EventArgs e)
        {
            ShowHidePanel(updateEmailSubMenuPanel);
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ShowHidePanel(changePasswordSubMenuPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowHidePanel(updateEmailSubMenuPanel);
        } 
        #endregion


        #region OpenSubMenusEvents
        private void finalUpdateAdressButton_Click(object sender, EventArgs e)
        {

            var results = AreYouSureMessage("Pay Loan");
            if (results == false)
            {
                return;
            }
            else
            {
                unitOfWork.Clients.UpdateAdress(LoginMenu.thisAccount, adressTextBox.Text, cityTextBox.Text);
                ActionSaved();
                this.Dispose();
            }
        }
        private void changePasswordFinalButton_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Pay Loan");
            if (results == false)
            {
                return;
            }
            else
            {
                ChangePassword();
                ActionSaved();
            }


        }
        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Pay Loan");
            if (results == false)
            {
                return;
            }
            else
            {
                ChangeEmail();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            var results = AreYouSureMessage("Pay Loan");
            if (results == false)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        #endregion


        #region MyMethods
        void ShowHidePanel(Panel panel)
        {
            if (panel.Visible)
                panel.Hide();
            else
            {
                panel.Show();
            }

        }
        void ChangePassword()
        {
            if (confirmPasswordTextBox.Text != newPasswordTextBox.Text)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "The Password Must Match !";
            }
            else
            {

                errorLabel.Visible = false;

                if (Validations.IsLegitPassword(newPasswordTextBox.Text))
                {
                    unitOfWork.Clients.UpdatePassword(LoginMenu.thisAccount, newPasswordTextBox.Text);
                    this.Dispose();
                }
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Must Contain at least 1 UpperCase letter and no symbols";
                }
            }
        }
        void ChangeEmail()
        {
            if (!Validations.IsLegitPhoneNumber(phoneNumberTextBox.Text))
            {
                emailErrorLabel.Visible = true;
                emailErrorLabel.Text = "Invaild Phone";
                return;
            }
            if (!Validations.IsLegitEmail(emailTextBox.Text))
            {
                emailErrorLabel.Visible = true;
                emailErrorLabel.Text = "Invaild Email";
                return;


            }
            if (phoneNumCheckBox.Checked && emailCheckBox.Checked && Validations.IsLegitEmail(emailTextBox.Text) && Validations.IsLegitPhoneNumber(phoneNumberLabel.Text))
            {
                unitOfWork.Clients.UpdatePhoneNumber(LoginMenu.thisAccount, phoneNumberTextBox.Text);
                unitOfWork.Clients.UpdateEmail(LoginMenu.thisAccount, emailTextBox.Text);
                this.Dispose();

            }
            else if (emailCheckBox.Checked)
            {
                unitOfWork.Clients.UpdateEmail(LoginMenu.thisAccount, emailTextBox.Text);
                this.Dispose();
            }
            else if (phoneNumCheckBox.Checked)
            {
                unitOfWork.Clients.UpdatePhoneNumber(LoginMenu.thisAccount, phoneNumberTextBox.Text);
                this.Dispose();
            }
        }
        void LoadAll()
        {

            ShowHidePanel(changePasswordSubMenuPanel);
            ShowHidePanel(personalDetailsSubMenuPanel);
            ShowHidePanel(updateEmailSubMenuPanel);
            currentAdressLabel.Text = unitOfWork.Clients.GetThisUserAdress(LoginMenu.thisAccount);
            currentCityLabel.Text = unitOfWork.Clients.GetThisUserCity(LoginMenu.thisAccount);
            currentEmailLabel.Text = unitOfWork.Clients.GetThisUserEmailAdress(LoginMenu.thisAccount);
            currentPasswordLabel.Text = unitOfWork.Accounts.GetThisUserPassword(LoginMenu.thisAccount);
            phoneNumberLabel.Text = unitOfWork.Clients.GetThisUserPhoneNum(LoginMenu.thisAccount);
            if (phoneNumCheckBox.Checked)
            {
                phoneNumberTextBox.Enabled = true;
            }
            else
            {
                phoneNumberTextBox.Enabled = false;
            }
            if (emailCheckBox.Checked)
            {
                emailTextBox.Enabled = true;
            }
            else
            {
                emailTextBox.Enabled = false;
            }
            emailErrorLabel.Visible = false;
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
        #endregion

        #region MouseEVENTS
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Crimson;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void updatePersonalDetailsButton_MouseEnter(object sender, EventArgs e)
        {
            updatePersonalDetailsButton.BackColor = Color.Crimson;
        }

        private void updatePersonalDetailsButton_MouseLeave(object sender, EventArgs e)
        {
            updatePersonalDetailsButton.BackColor = Color.Transparent;
        }

        private void changePasswordButton_MouseEnter(object sender, EventArgs e)
        {
            changePasswordButton.BackColor = Color.Crimson;
        }

        private void changePasswordButton_MouseLeave(object sender, EventArgs e)
        {
            changePasswordButton.BackColor = Color.Transparent;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Crimson;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Crimson;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        } 
        #endregion
    }
}
