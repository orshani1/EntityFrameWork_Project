using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss.Loans
{
    public interface ILoansRepository : IGenericRepository<Loan>
    {
        void PayLoan(Account account, Loan loan);
        void CreateNewLoan(Account account, int amount, int depoistAmount);
        void CreateNewLoan(Account account, DateTime startDate, DateTime endDate, int amount, int depoistAmount);
        int GetThisUserLoansAmountTotal(Account account);
        int GetThisUserLoansDepositsTotal(Account account);
    }
}