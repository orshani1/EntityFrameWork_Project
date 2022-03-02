using DigitalATM.DB.Modelss.Withdraw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalATM.DB.Modelss.Savings;
using DigitalATM.DB.Modelss.Loans;
using DigitalATM.DB.Modelss.Deposits;
using DigitalATM.DB.Modelss.AccountModel;
using DigitalATM.DB.Modelss.ClientModel;
using DigitalATM.DB.Modelss.CreditCardModel;

namespace DigitalATM.DB.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        IAccountRepository Accounts { get; }
        ILoansRepository Loans { get; }
        ICardRepository Cards { get; }
        IDepositRepository Deposits { get; }
        IWithDrawRepository WithDraw { get; }
        ISavingReposity Saving { get; }
        int Complete();

    }
}
