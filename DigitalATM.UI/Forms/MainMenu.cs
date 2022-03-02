using DigitalATM.DB.Modelss;
using DigitalATM.UI.UserControls.Admin;

namespace DigitalATM.UI
{
    public partial class MainMenu : Form
    {
        public List<UserControl> OpenedUserControls { get; set; } = new List<UserControl>();

        public bool IsSideMenuOpen { get; set; } = false;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

            if (IsAdmin())
            {
                adminSettingsButton.Visible = true;
                pictureBox10.Visible = true;
                pictureBox4.Visible = true;
            }//If the account is admin show admin button else ... 
            else
            {
                adminSettingsButton.Visible = false;
                pictureBox10.Visible = false;


            }
            HideAll();
            Greet();
            HomePage home = new HomePage();
            panelForUC.Controls.Add(home);
            home.BringToFront();
            home.Show();





        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (IsSideMenuOpen)
            {
                IsSideMenuOpen = false;
                pictureBox1.BackColor = Color.Transparent;
                subMenuPanel.Hide();
            }
            else
            {

                IsSideMenuOpen = true;
                pictureBox1.BackColor = Color.Transparent;
                subMenuPanel.Show();


            }
        }



        #region Show Or Hide Panels

        private void button1_Click_3(object sender, EventArgs e)
        {
            ShowHidePanel(transferPanel);

        }


        private void loanButton_Click(object sender, EventArgs e)
        {
            ShowHidePanel(loansPanel);
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            ShowHidePanel(creditCardPanel);
        }

        private void savingsButton_Click(object sender, EventArgs e)
        {
            ShowHidePanel(savingsPanel);
        }
        #endregion



        #region MouseHover Settings
        private void transferButton_MouseEnter(object sender, EventArgs e)
        {
            sideMenuPicturesPanel.BackColor = Color.FromArgb(40, 40, 40);
        }




        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(20, 20, 20);

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Crimson;

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;

        }






        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Crimson;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;

        }


        #endregion

        private void adminSettingsButton_Click(object sender, EventArgs e)
        {
            ShowHidePanel(adminSubMenuPanel);
        }

        #region Opening UserControls

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AccountCheck accountCheck = new AccountCheck();
            OpenUserControl(accountCheck);

        }

        private void transferMoneyButton_Click(object sender, EventArgs e)
        {
            TransferMoney transfer = new TransferMoney();
            OpenUserControl(transfer);

        }


        private void requstLoanButton_Click(object sender, EventArgs e)
        {
            Loans loans = new Loans();
            OpenUserControl(loans);
        }

        private void showMeLoanButton_Click(object sender, EventArgs e)
        {
            LoansListUC loansList = new LoansListUC();
            OpenUserControl(loansList);


        }

        private void repayLoanButton_Click(object sender, EventArgs e)
        {
            RepayLoanUC loans = new RepayLoanUC();
            OpenUserControl(loans);


        }

        private void disableCardButton_Click(object sender, EventArgs e)
        {
            DisabelCard disabelCard = new DisabelCard();
            OpenUserControl(disabelCard);


        }



        private void cardListButton_Click(object sender, EventArgs e)
        {
            CardList cardList = new CardList();
            OpenUserControl(cardList);


        }

        private void createnewSavingsButton_Click(object sender, EventArgs e)
        {
            CreateSaving createSaving = new CreateSaving();
            OpenUserControl(createSaving);


        }

        private void dipositSavigsButton_Click(object sender, EventArgs e)
        {
            DepositAndWithrawSaving withrawSaving = new DepositAndWithrawSaving();
            OpenUserControl(withrawSaving);


        }

        private void withdrawSavingButton_Click(object sender, EventArgs e)
        {
            SavingList savingList = new SavingList();
            OpenUserControl(savingList);


        }

        private void clientSettingsButton_Click(object sender, EventArgs e)
        {
            ClientsSettings clientsSettings = new ClientsSettings();
            OpenUserControl(clientsSettings);


        }

        private void creditCardsSettings_Click(object sender, EventArgs e)
        {
            CardSettings cardSettings = new CardSettings();
            OpenUserControl(cardSettings);



        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            ClientList clientList = new ClientList();
            OpenUserControl(clientList);


        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            OpenUserControl(homePage);

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            OpenUserControl(settings);


        }
        #endregion

        #region MyMethods
        private void Greet()
        {
            using (var db = new DigitalATMContext())
            {
                var client = db.Clients.Where(a => a.ClientId == LoginMenu.thisAccount.ClientId).
                    Select(a => a).FirstOrDefault();
                if (client != null)
                {

                    welcomeLabel.Text = $"Welcome {client.FirstName}";
                }
            }
        }
        void DisposeAllExcept(string userControlName)
        {
            foreach (var item in OpenedUserControls)
            {
                if (item.Name != userControlName)
                {
                    item.Dispose();
                }
            }
        }
        public void HideAll()
        {
            transferPanel.Hide();
            loansPanel.Hide();
            creditCardPanel.Hide();
            subMenuPanel.Hide();
            adminSubMenuPanel.Hide();
            savingsPanel.Hide();
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
        bool IsAdmin()
        {
            using (var db = new DigitalATMContext())
            {
                var admin = db.Admins.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                    Select(a => a).FirstOrDefault();
                if (admin != null)
                    return true;
                else
                    return false;
            }
        }
        void OpenUserControl(UserControl userControl)
        {
            userControl.Parent = panelForUC;
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
            ShowHidePanel(subMenuPanel);
            OpenedUserControls.Add(userControl);
            DisposeAllExcept(userControl.Name);
        }

        #endregion

        private void subMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(30,30,30);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor=Color.Transparent;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WriteToAccounts write = new WriteToAccounts();
            OpenUserControl(write);
        }
    }

}
