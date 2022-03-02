
using System.Net.Mail;
using DigitalATM.Logic;
using DigitalATM.DB;


namespace DigitalATM.UI
{
    public partial class ForgotPasswordForm : Form
    {
        public int randomCode { get; set; }
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Insert your Username and Email adress\nWe will send you a code to your emaill adress\ninsert to code below to continue ";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validations.IsAlreadyExsistUserName(textBox1.Text))
            {
               var methodList = MethodList.GetInstance();
               var code =  methodList.SendCodeThroughEmail(textBox2.Text,textBox1.Text);
                randomCode = int.Parse(code);
                codeLabel.Visible = true;
                codeTextBox.Visible = true;
                enterCodeButton.Visible = true;

            }

            else
            {
                MessageBox.Show("UserName is not in our system");
            }
        }



        private void enterCodeButton_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text == randomCode.ToString())
            {
                var methodList = MethodList.GetInstance();
               var message = methodList.SendPasswordThroughEmail(textBox2.Text,textBox1.Text);
                MessageBox.Show(message);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("The Code You Intered Is not Match");
            }
        }
    }
}
