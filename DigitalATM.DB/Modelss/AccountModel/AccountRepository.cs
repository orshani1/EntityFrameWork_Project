using DigitalATM.DB.GenericRepository;
using System.Diagnostics;
using DigitalATM.DB.Modelss.CreditCardModel;
using DigitalATM.DB.Modelss.ClientModel;

namespace DigitalATM.DB.Modelss.AccountModel
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {

        public AccountRepository(DigitalATMContext context) : base(context)
        {

        }
        public void CheckAccount(Account account)
        {

            foreach (var action in account.Loans)
            {
                if (action.StartDate >= DateTime.Today && DateTime.Today < action.EndDate)
                {
                    if (action.DepositAmount != null)
                    {
                        var depositAmount = Convert.ToInt32(action.DepositAmount);
                        account.Balance -= depositAmount;
                        using (var db = new DigitalATMContext())
                        {
                            var acc = db.Accounts.Where(a => a.AccountId == account.AccountId).
                                Select(a => a).FirstOrDefault();
                            if (acc != null)
                            {
                                acc.AccountActions.Add(new AccountAction()
                                {
                                    Account = account,
                                    AccountId = account.AccountId,
                                    ActionId = action.Id,
                                    Amount = Convert.ToInt32(action.DepositAmount),
                                    Date = action.StartDate,
                                    Description = $"Loan Deposit {action.DepositAmount}"
                                }
                                    );
                            }
                        }
                    }
                }
            }
        }
        public Account? ConverToAccount(string username, string password)
        {
            Account account;
            using (var db = new DigitalATMContext())
            {

                try
                {

                    account = db.Accounts.Where(a => a.UserName == username && a.Password == password).
                           Select(a => a).First();
                }
                catch (Exception ex)
                {

                    throw new Exception($"{ex}");
                }


            }
            return account;
        }
        public Account? CreateUserInstance(string? address, string? city, string? email, string? firstName, string? lastName, string? userName, string? password, int? phoneNumber, string? slectedBank)
        {

            //Design Pattern Factory Method
            Account finalAccount = new Account();
            var bankNumber = GenerateRandomBankNumber();
            var bankName = slectedBank;
            using (var check = new DigitalATMContext())
            {
                #region Query's Check (if bank number already exist, getting the bank id)
                var query = check.Accounts.Where(a => a.BankAccNumber == int.Parse(bankNumber)).
                               Select(a => a.BankId).ToArray();//Query to check if bank number is already Exist
                var generatedId = check.Banks.Where(b => b.BankName == bankName).
                    Select(b => b.BankId).ToArray();//Getting the bank id for The SelectedBank
                var generetedBankName = check.Banks.Where(b => b.BankName == bankName).
                    Select(b => b.BankName).ToArray();
                #endregion
                if (query.Length == 0)//Checking if There isnt any user with the same Bank Number 
                {
                    var bank = GetBank(bankName);

                    //Adding the new User To the DB By creating instances
                    #region Instances(Client,Bank,Account)
                    var client = new Client()
                    {

                        Adress = address,
                        City = city,
                        Email = email,
                        FirstName = firstName,
                        LastName = lastName,
                        PhoneNumber = phoneNumber.ToString(),





                    };
                    var account = new Account()
                    {
                        Client = client,
                        BankAccNumber = int.Parse(bankNumber),
                        Balance = 200,
                        Bank = bank,
                        UserName = userName,
                        Password = password,
                        ClientId = client.ClientId,





                    };
                    #endregion

                    finalAccount = account;
                }

                return finalAccount;
            }



        }
        public Account? CreateUserInstance(string? address, string? city, string? email, string? firstName, string? lastName, string? userName, string? password, int? phoneNumber, string? slectedBank, bool isCreditCard)
        {
            //Design Pattern Factory Method
            Account finalAccount = new Account();
            var bankNumber = GenerateRandomBankNumber();
            var bankName = slectedBank;
            using (var check = new DigitalATMContext())
            {
                #region Query's Check (if bank number already exist, getting the bank id)
                var query = check.Accounts.Where(a => a.BankAccNumber == int.Parse(bankNumber)).
                               Select(a => a.BankId).ToArray();//Query to check if bank number is already Exist
                var generatedId = check.Banks.Where(b => b.BankName == bankName).
                    Select(b => b.BankId).ToArray();//Getting the bank id for The SelectedBank
                var generetedBankName = check.Banks.Where(b => b.BankName == bankName).
                    Select(b => b.BankName).ToArray();
                #endregion
                if (query.Length == 0)//Checking if There isnt any user with the same Bank Number 
                {
                    var bank = GetBank(bankName);

                    //Adding the new User To the DB By creating instances
                    #region Instances(Client,Bank,Account)

                    var account = new Account()
                    {
                        BankAccNumber = int.Parse(bankNumber),
                        Balance = 200,
                        UserName = userName,
                        Password = password,

                        BankId = bank.BankId,
                        Client = new Client()
                        {

                            Adress = address,
                            City = city,
                            Email = email,
                            FirstName = firstName,
                            LastName = lastName,
                            PhoneNumber = phoneNumber.ToString(),

                        },






                    };
                    #endregion


                    #region Generating Random Cards Details (Number,CCV)
                    var random = new Random();
                    var ccv = string.Empty;
                    var secondryCcv = new int[3] { random.Next(0, 10), random.Next(0, 10), random.Next(0, 10) };
                    foreach (var item in secondryCcv)
                    {
                        ccv += item.ToString();
                    }
                    var cardNumber = GenerateRandomCreditNumber();



                    #endregion

                    #region CreditCard Instance

                    CreditCard credit = new CreditCard()
                    {
                        CardCvv = int.Parse(ccv),
                        CardNumber = cardNumber,
                        CardExpiredDate = DateTime.Now.AddYears(2),
                        CardHolder = firstName + " " + lastName


                    };
                    #endregion
                    account.CreditCards.Add(credit);

                    finalAccount = account;
                    credit.Account = finalAccount;
                }

                return finalAccount;
            }



        }
  

        public string GetThisUserPassword(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                var password = db.Accounts.Where(a => a.AccountId == account.AccountId).
                    Select(a => a.Password).FirstOrDefault();
                if (password != null)
                {
                    return password;
                }
                else
                {
                    return "null";
                }
            }
        }
        public int GetUserBalance(Account account)
        {
            var balance = 0;
            using (var db = new DigitalATMContext())
            {
                balance = db.Accounts.Where(a => a.AccountId == account.AccountId).Select(a => a.Balance).FirstOrDefault();

            }
            return balance;
        }
        public void RestorePassword(string usernameInput)
        {
            using (var db = new DigitalATMContext())
            {
                var qury =
                    from client in db.Accounts
                    where client.UserName == usernameInput
                    select client;
                foreach (var client in qury)
                {
                    client.Password = "RestoredPassword123";
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {

                    Debug.WriteLine(e);
                }
            }


        }

        private Bank GetBank(string bankName)
        {

            using (var db = new DigitalATMContext())
            {
                var thisBank = db.Banks.Where(b => b.BankName == bankName).
                     Select(b => b).First();
                return thisBank;
            }

        }
        private string GenerateRandomBankNumber()
        {
            string bankNumber = string.Empty;
            for (int i = 0; i <= 8; i++)
            {
                var rand = new Random();
                bankNumber += rand.Next(0, 10).ToString();

            }
            return bankNumber;
        }
        private int GenerateRandomCreditNumber()
        {
            var random = new Random();


            var cardNumber = string.Empty;
            var cardNumberArray = new int[6];
            foreach (var item in cardNumberArray)
            {
                cardNumber += random.Next(0, 10);
            }

            return int.Parse(cardNumber);

        }

        public List<AccountAction> OrderActionFromDateToDate(Account account, DateTime startDate, DateTime endDate)
        {
            using (var db = new DigitalATMContext())
            {
                var actionList = db.AccountActions.Where(c => c.Date >= startDate.Date && c.Date <= endDate).Select(c => c).ToList();
                return actionList;

               
            }
        }
        
    }
}
