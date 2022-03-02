using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss.Deposits
{
    public interface IDepositRepository : IGenericRepository<Deposit>
    {
        void CreateNewDeposit(Account account, int amount);
    }
}