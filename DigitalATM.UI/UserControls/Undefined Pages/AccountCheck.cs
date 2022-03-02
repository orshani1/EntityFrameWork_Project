using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss;
using System.Data;

namespace DigitalATM.UI
{
    public partial class AccountCheck : UserControl
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public DigitalATMContext _context { get; set; } = new DigitalATMContext();  

        public AccountCheck()
        {
            UnitOfWork = new UnitOfWork(_context);
            InitializeComponent();
        }

        #region Styling
        private void returnPicBox_MouseEnter(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Crimson;
        }

        private void returnPicBox_MouseLeave(object sender, EventArgs e)
        {
            returnPicBox.BackColor = Color.Transparent;

        }

        #endregion
        private void returnPicBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AccountCheck_Load(object sender, EventArgs e)
        {
            var client = LoginMenu.thisAccount;
            using (var db = new DigitalATMContext())
            {
                var list = db.AccountActions.Where(a => a.AccountId == client.AccountId).
                 Select(a => a).ToList();
                balanceLabel.Text = $"{client.Balance.ToString()}$";
                dateLabel.Text = DateTime.Now.ToString();
                dataGridView1.DataSource = list;

            }

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Description")
            {
                SortBy("Description");
            }
            else if (listBox1.SelectedItem.ToString() == "Amount")
            {
                SortBy("Amount");
            }
            else if (listBox1.SelectedItem.ToString() == "Date")
            {
                SortBy("Date");
            }
            else
            {
                SortBy("Id");
            }
            
            
        }
        #region MyMethods
        public void SortBy(string sortTerm)
        {
            using (var db = new DigitalATMContext())
            {
                if (sortTerm == "Description")
                {
                    dataGridView1.DataSource = db.AccountActions.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                        Select(a => a).OrderBy(a => a.Description).ToList();
                }
                else if (sortTerm == "Amount")
                {
                    dataGridView1.DataSource = db.AccountActions.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                       Select(a => a).OrderBy(a => a.Amount).ToList();
                }
                else if (sortTerm == "Date")
                {
                    dataGridView1.DataSource = db.AccountActions.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                     Select(a => a).OrderBy(a => a.Date).ToList();
                }
                else
                {
                    dataGridView1.DataSource = db.AccountActions.Where(a => a.AccountId == LoginMenu.thisAccount.AccountId).
                        Select(a => a).OrderBy(a => a.Id).ToList();
                }
            }
        } //Method To Sort the list box 
        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void endDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            showButton.Enabled = true;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            var account = LoginMenu.thisAccount;
            var list = UnitOfWork.Accounts.OrderActionFromDateToDate(account, startDateTimePicker1.Value.Date, endDateTimePicker2.Value.Date);
            dataGridView1.DataSource = list;

        }
    }
}
