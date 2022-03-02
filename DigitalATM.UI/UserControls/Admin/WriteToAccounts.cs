using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss;
using DigitalATM.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalATM.UI.UserControls.Admin
{
    public partial class WriteToAccounts : UserControl
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public DigitalATMContext Context { get; set; } = new DigitalATMContext();
        public WriteToAccounts()
        {
            UnitOfWork = new UnitOfWork(Context);
            InitializeComponent();
        }

        private void WriteToAccounts_Load(object sender, EventArgs e)
        {
            var clientsNameList = new List<string>();
            var clientsList = UnitOfWork.Clients.GetAllClients();
            foreach (var client in clientsList)
            {
                clientsNameList.Add(client.FirstName + " " + client.LastName);
            }
            clientsComboBox.DataSource = clientsNameList;
            var selectedClientFullName = clientsComboBox.SelectedValue.ToString();
            if (selectedClientFullName != null)
            {

                var selectedClientFirstName = selectedClientFullName.Split()[0];
                var selectedClientLastName = selectedClientFullName.Split()[1];

                string? email = clientsList.Where(c => c.FirstName == selectedClientFirstName && c.LastName == selectedClientLastName).Select(c => c.Email).FirstOrDefault().ToString();
                if (email != null)
                {
                    EmailtextBox.Text = email;
                }
            }



        }

        private void clientsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedClientFullName = clientsComboBox.SelectedValue.ToString();

            var clientsList = UnitOfWork.Clients.GetAllClients();
            if (selectedClientFullName != null)
            {

                var selectedClientFirstName = selectedClientFullName.Split()[0];
                var selectedClientLastName = selectedClientFullName.Split()[1];
                string? email = clientsList.Where(c => c.FirstName == selectedClientFirstName && c.LastName == selectedClientLastName).Select(c => c.Email).FirstOrDefault().ToString();
                if (email != null)
                {
                    EmailtextBox.Text = email;
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var selectedClientFullName = clientsComboBox.SelectedValue.ToString();

            var clientsList = UnitOfWork.Clients.GetAllClients();
            if (selectedClientFullName != null)
            {

                var selectedClientFirstName = selectedClientFullName.Split()[0];
                var selectedClientLastName = selectedClientFullName.Split()[1];
                string? email = clientsList.Where(c => c.FirstName == selectedClientFirstName && c.LastName == selectedClientLastName).Select(c => c.Email).FirstOrDefault().ToString();
                if (email != null)
                {
                }
                if (allCheckBox.Checked)
                {
                    IEmailManagment emailManagment = MethodList.GetInstance();
                    emailManagment.SendAllUsersMessage(subjectTextBox.Text, bodyRichTextBox.Text);

                }
                else
                {
                    IEmailManagment emailManagment = MethodList.GetInstance();
                    emailManagment.SendMessageThroughEmail(email, subjectTextBox.Text, bodyRichTextBox.Text);
                    MessageBox.Show("Message Deliverid");

                }
            }
        }
    }
}
