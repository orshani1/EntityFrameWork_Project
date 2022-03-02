
using System.Data;

using static DigitalATM.UI.RegisterForm;
using DigitalATM.UI;
using DigitalATM.DB.Modelss;
using DigitalATM.Logic;
using DigitalATM.DB;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss.AccountModel;

namespace ATM.UI
{
    public partial class RegisterPhaseTwo : UserControl
    {
        private int randomCode;

        public DigitalATMContext Context { get; set; } = new DigitalATMContext();
        public IUnitOfWork UnitOfWork { get; set; }
        public RegisterForm firstPhaseForm { get; set; } = new RegisterForm();
        public RegisterPhaseTwo()
        {
            InitializeComponent();
        }

        private void RegisterPhaseTwo_Load(object sender, EventArgs e)
        {

            using (var db = new DigitalATMContext())
            {

                var data = db.Banks.Select(d => d.BankName).ToList();
                bankListBox.DataSource = data;



            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firstnameTextBox_Click(object sender, EventArgs e)
        {
            firstnameTextBox.Clear();
        }

        private void lastnameTextBox_Click(object sender, EventArgs e)
        {
            lastnameTextBox.Clear();
        }

        #region ButtonsBackColorSettings

        private void sendButton_MouseLeave(object sender, EventArgs e)
        {
            sendButton.BackColor = Color.Transparent;

        }

        private void sendButton_MouseEnter(object sender, EventArgs e)
        {
            sendButton.BackColor = Color.Crimson;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.Crimson;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.Transparent;

        }
        #endregion

        private void sendButton_Click(object sender, EventArgs e)
        {
            CommitAction(); 
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
                    UnitOfWork = new UnitOfWork(Context);
            if (CodeTextBox.Text == randomCode.ToString())//Checking if the Code match 
            {

                #region Matching the client instance prop

                var selectedBank = bankListBox.GetItemText(bankListBox.SelectedItem);
                var address = FormsConnections.Adress;
                var city = FormsConnections.City;
                var userName = FormsConnections.UserName;
                var password = FormsConnections.UserPassword;
                var phoneNumber = Convert.ToInt32(FormsConnections.PhoneNumber);
                var email = FormsConnections.Email;
                var firstName = firstnameTextBox.Text;
                var lastName = lastnameTextBox.Text;
                #endregion







                if (checkBox1.Checked)//I Want credit card check box is checked
                {

                    //Factory Method Design Pattern Below  Create User Instance
                    var clientCredit = UnitOfWork.Accounts.CreateUserInstance(address, city, email, firstName, lastName,userName,password, phoneNumber, selectedBank, true);
                    IGenericRepository<Account> genericRepository = new GenericRepository<Account>(new DigitalATMContext());
                    UnitOfWork.Accounts.SaveAccount(clientCredit);
                    var methodList = MethodList.GetInstance();//SingleTone DesignPattern
                    methodList.SendAccountDetailsThroughEmail(clientCredit);
                    #region MBprop
                    var text2 = "User Saved Email will be sent with all the details";
                    var caption2 = "User Saved!";
                    var icon2 = MessageBoxIcon.Information;
                    var button2 = MessageBoxButtons.OK;
                    MessageBox.Show(text2, caption2, button2, icon2);
                    #endregion
                    CloseAllFormsExcept("LoginMenu");
                    RegisterForm.thisClient = clientCredit;


                }//I Want credit card check box is checked
                else
                {
                    IEmailManagment methodList = MethodList.GetInstance();//SingleTone DesignPattern and Polymorpisem
                    var client = UnitOfWork.Accounts.CreateUserInstance(address, city, email, firstName, lastName, userName, password, phoneNumber, selectedBank);
                    IGenericRepository<Account> genericRepository = new GenericRepository<Account>(new DigitalATMContext());
                    UnitOfWork.Accounts.SaveAccount(client);


                    methodList.SendAccountDetailsThroughEmail(client);
                    RegisterForm.thisClient = client;
                    #region MBprop
                    var text2 = "User Saved Email will be sent with all the details";
                    var caption2 = "User Saved!";
                    var icon2 = MessageBoxIcon.Information;
                    var button2 = MessageBoxButtons.OK;
                    MessageBox.Show(text2, caption2, button2, icon2);
                    #endregion
                    CloseAllFormsExcept("LoginMenu");
                } //I Dont Want credit card check box is checked

            }
            else//CodeMisMatch
            {

                #region MessageBoxProp
                var caption = "Code Mismatch";
                var text = "The code you entered is not Match You can re send it by clicking send";
                var button = MessageBoxButtons.OK;
                var icon = MessageBoxIcon.Error;
                #endregion//CodeMisMatch
                MessageBox.Show(text, caption, button, icon);
            } //Code dont match 
        }



        #region SomeButtonBehaviorChange
        private void verificetionMethodListBox_DoubleClick(object sender, EventArgs e)
        {
            sendButton.Enabled = true;
        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            registerButton.Enabled = true;
        }
        #endregion
        #region MyMethods
        public static void CloseAllFormsExcept(string formName)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != formName)
                    f.Close();


            }
        }
        void CommitAction()
        {
            var email = RegisterForm.FormsConnections.Email;

            var selectedItem = verificetionMethodListBox.GetItemText(verificetionMethodListBox.SelectedItem);
            if (selectedItem == "Phone")
            {
                var methodList = MethodList.GetInstance();
                methodList.SendCodeSms();


            }
            else if (selectedItem == "Email")
            {
                var methodList = MethodList.GetInstance();
                #region Sending Random Code to email
                var randomnum = new Random();
                var code = string.Empty;
                for (int i = 0; i < 6; i++)
                {
                    var finalDigit = randomnum.Next(0, 11);
                    code += finalDigit.ToString();
                }
                randomCode = int.Parse(code);
                var subject = "Digital ATM register code";
                var body = $"Hello Dear {firstnameTextBox.Text},\n\n\nWe so happy to have your as our new client in our" +
                    $" digital ATM software.\n\n in our software you could gain acces to all your bank actions while you sit " +
                    $"at home and drink something warm.\n\n\nThis is the final step in your registery please insert the code" +
                    $"below to finish your registery:" + "\n\n";
                methodList.SendCodeThroughEmail(email, subject, body, code);
                #endregion
                inserCodeLabel.Visible = true;
                CodeTextBox.Visible = true;

            }
        }
        #endregion

        private void verificetionMethodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}

