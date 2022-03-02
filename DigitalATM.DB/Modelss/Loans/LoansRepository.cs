using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Modelss.AccountModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalATM.DB.Modelss.Loans
{
    public class LoansRepository : GenericRepository<Loan>, ILoansRepository
    {
        public LoansRepository(DigitalATMContext context) : base(context)
        {
        }
        public void CreateNewLoan(Account account, int amount, int depoistAmount)
        {
            if (account.AccountId == 0)
            {
                account.AccountId = 200;
            }
            using (var db = new DigitalATMContext())
            {
                Loan loan = new Loan()
                {
                    StartDate = DateTime.Today.Date,
                    Amount = amount,
                    DepositAmount = depoistAmount,
                    EndDate = DateTime.Today.Date.AddMonths(6)

                };
                AccountAction action = new AccountAction()
                {
                    AccountId = account.AccountId,
                    Amount = amount,
                    Date = DateTime.Today.Date,
                    Description = $"Loan Requset Amount of {amount}",

                };
                account.Loans.Add(loan);
                var change = db.Accounts.Where(a => a.AccountId == account.AccountId).
                    Select(a => a);
                change.First().Balance += amount;
                change.AsNoTracking();
                account.Loans.Add(loan);
                db.Loans.Add(loan);
                db.SaveChanges();
                action.ActionId = loan.Id;
                db.AccountActions.Add(action);
                db.SaveChanges();
                loan.AccountId = account.AccountId;
                loan.Account = account;
                db.SaveChanges();
            }
        }
        public void CreateNewLoan(Account account, DateTime startDate, DateTime endDate, int amount, int depoistAmount)
        {
            if (account.AccountId == 0)
            {
                account.AccountId = 200;
            }
            using (var db = new DigitalATMContext())
            {
                Loan loan = new Loan()
                {
                    StartDate = startDate,
                    Amount = amount,
                    DepositAmount = depoistAmount,
                    EndDate = endDate,

                };
                AccountAction action = new AccountAction()
                {
                    AccountId = account.AccountId,
                    Amount = amount,
                    Date = startDate,
                    Description = $"Loan Requset Amount of {amount}",

                };
                account.Loans.Add(loan);
                var change = db.Accounts.Where(a => a.AccountId == account.AccountId).
                    Select(a => a);
                change.First().Balance += amount;
                change.AsNoTracking();

                account.Loans.Add(loan);
                db.Loans.Add(loan);
                db.SaveChanges();
                action.ActionId = loan.Id;
                db.AccountActions.Add(action);
                db.SaveChanges();
                loan.AccountId = account.AccountId;
                loan.Account = account;
                db.SaveChanges();







            }
        }
        public int GetThisUserLoansAmountTotal(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                var total = 0;
                var subTotal = db.Loans.Where(l => l.AccountId == account.AccountId).Select(l => l).ToList();
                foreach (var loan in subTotal)
                {
                    if (loan.Amount != null)
                    {

                        total += (int)loan.Amount;
                    }
                }
                return total;
            }
        }
        public int GetThisUserLoansDepositsTotal(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                var total = 0;
                var subTotal = db.Loans.Where(l => l.AccountId == account.AccountId).Select(l => l).ToList();
                foreach (var loan in subTotal)
                {
                    if (loan.DepositAmount != null)
                    {

                        total += (int)loan.DepositAmount;
                    }
                }
                return total;
            }

        }
        public void PayLoan(Account account, Loan loan)
        {
            using (var db = new DigitalATMContext())
            {
                var clientAction = db.AccountActions.Where(a => a.AccountId == account.AccountId && a.ActionId == loan.Id).
                    Select(a => a).FirstOrDefault();
                db.Remove(clientAction);
                account.Balance -= Convert.ToInt32(loan.Amount);
                account.Loans.Remove(loan);
                account.AccountActions.Remove(clientAction);
                db.Loans.Remove(loan);
                db.AccountActions.Remove(clientAction);
                db.AccountActions.Add(new AccountAction()
                {
                    AccountId = account.AccountId,
                    ActionId = loan.Id,
                    Amount = Convert.ToInt32(loan.Amount),
                    Date = DateTime.Today.Date,
                    Description = $"Pay Loan Of {loan.Amount}",


                });
                db.SaveChanges();

            }
        }
    }
}
