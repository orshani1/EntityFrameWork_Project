using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Modelss.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalATM.DB.Modelss.Withdraw
{
    public class WithdrawRepository : GenericRepository<WithDraw>,IWithDrawRepository
    {
        public WithdrawRepository(DigitalATMContext context) : base(context)
        {
        }

        public void CreateNewWithDraw(Account account, int amount)
        {
            using (var db = new DigitalATMContext())
            {

                WithDraw withDraw = new WithDraw()
                {
                    AccountId = account.AccountId,
                    Amount = amount,
                    WithdrawDate = DateTime.Today.Date,

                };
                db.WithDraws.Add(withDraw);
                db.SaveChanges();
                AccountAction action = new AccountAction()
                {
                    AccountId = account.AccountId,
                    ActionId = withDraw.Id,
                    Amount = amount,
                    Date = DateTime.Today.Date,
                    Description = $"Withdraw Of {amount} Dollars",

                };
                db.AccountActions.Add(action);
                var acc = db.Accounts.Where(a => a.AccountId == account.AccountId).Select(a => a).FirstOrDefault();
                acc.Balance -= amount;

                db.SaveChanges();

            }
        }
    }
}
