using DigitalATM.DB.Interfaces;

namespace DigitalATM.DB.Modelss.AccountModel
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
           
        string GetThisUserPassword(Account account);
        int GetUserBalance(Account account);
        void CheckAccount(Account account);
        void RestorePassword(string usernameInput);
        Account? ConverToAccount(string username, string password);
        Account? CreateUserInstance(string? address, string? city, string? email, string? firstName, string? lastName, string? userName, string? password, int? phoneNumber, string? slectedBank);
        Account? CreateUserInstance(string? address, string? city, string? email, string? firstName, string? lastName, string? userName, string? password, int? phoneNumber, string? slectedBank, bool isCreditCard);
        void SaveAccount(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                db.Accounts.Add(account);
                db.SaveChanges();   
            }
        }

        List<AccountAction> OrderActionFromDateToDate(Account account, DateTime startDate, DateTime endDate);
  

    }
}
