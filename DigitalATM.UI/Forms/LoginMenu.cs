using DigitalATM.DB.Modelss;
using DigitalATM.DB;
using DigitalATM.Logic;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss.AccountModel;
using System.Diagnostics;

namespace DigitalATM.UI
{

    public partial class LoginMenu : Form
    {
        public IUnitOfWork  UnitOfWork { get; set; }
        public DigitalATMContext Context { get; set; } = new DigitalATMContext();


        public static RegisterForm registerForm = new RegisterForm();
        public static Account? thisAccount;
        

        public LoginMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            welcomeLabel.Greet();
            dateLabel.Text = DateTime.Now.ToString();
     
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #region Styling

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            LogInButton.BackColor = Color.FromArgb(30, 30, 30);
        }


        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);

        }

        private void LogInButton_MouseLeave(object sender, EventArgs e)
        {
            LogInButton.BackColor = Color.Crimson;
        }

        private void RegisterButton_MouseEnter(object sender, EventArgs e)
        {
            RegisterButton.Font = new Font(RegisterButton.Font.Name, RegisterButton.Font.SizeInPoints, FontStyle.Underline);
        }

        private void RegisterButton_MouseLeave(object sender, EventArgs e)
        {
            RegisterButton.Font = new Font(RegisterButton.Font.Name, RegisterButton.Font.SizeInPoints, FontStyle.Regular);

        } 
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            userNameTxtBox.Clear();
            pictureBox1.Hide();

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            pictureBox2.Hide();
            textBox2.PasswordChar = '*';
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {


            if (Validations.IsAlreadyExsistUserName(userNameTxtBox.Text))
            {

                UnitOfWork = new UnitOfWork(Context);
                thisAccount = UnitOfWork.Accounts.ConverToAccount(userNameTxtBox.Text, textBox2.Text);
                UnitOfWork.Accounts.CheckAccount(thisAccount);
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }

            else
            {
                LoginErrorLabel.Visible = true;
                timer1.Interval = 3000;
                timer1.Tick += (s, d) =>
                {

                    LoginErrorLabel.Visible = false;
                    timer1.Stop();
                };
                timer1.Start();
                userNameTxtBox.Clear();
                textBox2.Clear();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.Location = new Point(1400, 250);
            form.ShowDialog();
        }
        #region Styling

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Crimson;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        } 
        #endregion

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
            registerForm.WindowState = FormWindowState.Normal;
            registerForm.ShowDialog();

        }

        private void ourWebLabel_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;
            p.StartInfo = info;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(@"cd C:\Users\user\Desktop\softwaredev\DigitalATMProject\Our website");
                    sw.WriteLine("index.html");
                }
            }

        }

        private void ourWebLabel_MouseEnter(object sender, EventArgs e)
        {
            ourWebLabel.Font = new Font(ourWebLabel.Font.Name,ourWebLabel.Font.SizeInPoints,FontStyle.Underline);
        }

        private void ourWebLabel_MouseLeave(object sender, EventArgs e)
        {
            ourWebLabel.Font = new Font(ourWebLabel.Font.Name, ourWebLabel.Font.SizeInPoints, FontStyle.Regular);

        }
    }
}