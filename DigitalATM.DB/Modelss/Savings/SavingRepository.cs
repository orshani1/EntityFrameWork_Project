using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Modelss.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalATM.DB.Modelss.Savings
{
    public class SavingRepository : GenericRepository<Saving>, ISavingReposity
    {
        public SavingRepository(DigitalATMContext context) : base(context)
        {
        }

        public void CreateNewSaving(Account account, int amount, string name)
        {
            using (var db = new DigitalATMContext())
            {
                Saving saving = new Saving()
                {
                    AccountId = account.AccountId,
                    Amount = amount,
                    SaveName = name,
                    StartDate = DateTime.Today.Date,

                };
                AccountAction action = new AccountAction()
                {
                    AccountId = account.AccountId,
                    Amount = amount,
                    Date = DateTime.Today.Date,
                    Description = $"Deposit To Saving {amount}",

                };
                account.Balance -= action.Amount;
                db.Savings.Add(saving);
                db.SaveChanges();
                action.ActionId = saving.Id;

                db.AccountActions.Add(action);
                db.SaveChanges();
            }
        }

        public Saving GetSaving(string savingName)
        {
            using (var db = new DigitalATMContext())
            {
                var saving = db.Savings.Where(s => s.SaveName == savingName).
                    Select(s => s).FirstOrDefault();

                return saving;
            }
        }
    }
}
