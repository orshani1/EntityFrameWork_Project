using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Modelss.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalATM.DB.Modelss.Deposits
{
    public class DepositRepository : GenericRepository<Deposit>, IDepositRepository
    {
        public DepositRepository(DigitalATMContext context) : base(context)
        {
        }

        public void CreateNewDeposit(Account account, int amount)
        {
            using (var db = new DigitalATMContext())
            {

                Deposit deposit = new Deposit()
                {
                    AccountId = account.AccountId,
                    Amount = amount,
                    DepositDate = DateTime.Today.Date,

                };
                db.Deposits.Add(deposit);
                db.SaveChanges();
                AccountAction action = new AccountAction()
                {
                    AccountId = account.AccountId,
                    ActionId = deposit.Id,
                    Amount = amount,
                    Date = DateTime.Today.Date,
                    Description = $"Deposit Of {amount} Dollars",

                };
                db.AccountActions.Add(action);
                var acc = db.Accounts.Where(a => a.AccountId == account.AccountId).Select(a => a).FirstOrDefault();
                acc.Balance += amount;

                db.SaveChanges();




            }
        }
    }
}
