using ATM.UI;
using DigitalATM.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.UI
{
    public partial class RegisterForm : Form
    {
        public static Account thisClient { get; set; }
        public static class FormsConnections
        {


            public static string? Email { get; set; }
            public static string? Adress { get; set; }
            public static string? City { get; set; }
            public static int? PhoneNumber { get; set; }
            public static string? UserName { get; set; }
            public static string? UserPassword { get; set; }
        }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
         
        }

        #region ButtonHover
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }
        #endregion
        #region ErrorLabelActivities

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (!Validations.IsUserName(usernameTextBox.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Invaild Username at least 6 digits\nNo Symbols";

            }
            else
            {
                errorLabel.Visible = false;

            }


        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Validations.IsLegitPassword(passwordTextBox.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Password Must contain at least 1 Upper Case letter";


            }
            else
            {
                errorLabel.Visible = false;

            }
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text != passwordTextBox.Text)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Password Must Be Match";


            }
            else
            {
                errorLabel.Visible = false;

            }
        }

        private void emailTextBoX_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (!regex.IsMatch(emailTextBoX.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Invalid Email!";
            }
            else
            {
                errorLabel.Visible = false;

            }
        }

        private void adressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (adressTextBox.TextLength == 0)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Must add adress!";


            }
            else
            {
                errorLabel.Visible = false;

            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cityTextBox.TextLength == 0)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Must add City!";


            }
            else
            {
                errorLabel.Visible = false;

            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$");
            if (!regex.IsMatch(phoneNumberTextBox.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Invaild Phone Number";



            }
            else
            {
                errorLabel.Visible = false;

            }
        }
        #endregion

        #region Clearing the TextBoxes
        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
        }
        void UserNameTxtBx_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
        }
        void ConfirmPassword_Click(object sender, EventArgs e)
        {
            confirmPasswordTextBox.Clear();
        }
        void Email_Click(object sender, EventArgs e)
        {
            emailTextBoX.Clear();
        }
        void Adress_Click(object sender, EventArgs e)
        {
            adressTextBox.Clear();
        }
        void City_Click(object sender, EventArgs e)
        {
            cityTextBox.Clear();
        }
        void Phone_Click(object sender, EventArgs e)
        {
            phoneNumberTextBox.Clear();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            if (IsTextsLegit())
            {
                FormsConnections.UserName = usernameTextBox.Text;
                FormsConnections.UserPassword = passwordTextBox.Text;
                FormsConnections.Email = emailTextBoX.Text;
                FormsConnections.Adress = adressTextBox.Text;
                FormsConnections.City = cityTextBox.Text;
                FormsConnections.PhoneNumber = Convert.ToInt32(phoneNumberTextBox.Text);
                RegisterPhaseTwo phaseTwo = new RegisterPhaseTwo();
                phaseTwo.Parent = containerPanel;
                containerPanel.BringToFront();
                containerPanel.Controls.Add(phaseTwo);
                

            }

            else
            {
                #region MessageBoxProp
                var text = "this user is already exsists Or one of the fields you entered is worng\nCheck Again";
                var captio = "Register Error";
                var buttons = MessageBoxButtons.OK;
                var icon = MessageBoxIcon.Error;
                #endregion
                MessageBox.Show(text,captio,buttons,icon);
            }

        }

        public bool IsTextsLegit()
        {
            if (!Validations.IsAdressEmpty(adressTextBox.Text) &&
            !Validations.IsAdressEmpty(cityTextBox.Text) &&
            Validations.IsLegitEmail(emailTextBoX.Text) &&
            Validations.IsLegitPassword(passwordTextBox.Text) &&
            Validations.IsLegitPhoneNumber(phoneNumberTextBox.Text) &&
            Validations.IsUserName(usernameTextBox.Text)&&
            !Validations.IsAlreadyExsistUserName(usernameTextBox.Text))
            {
                return true;
            }
            return false;
        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


