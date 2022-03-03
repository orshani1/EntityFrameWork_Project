using DigitalATM.DB.Modelss;
using DigitalATM.DB.Modelss.Withdraw;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss.Savings;
using DigitalATM.DB.Modelss.Loans;
using DigitalATM.DB.Modelss.Deposits;
using DigitalATM.DB.Modelss.AccountModel;
using DigitalATM.DB.Modelss.ClientModel;
using DigitalATM.DB.Modelss.CreditCardModel;

namespace DigitalATM.DB.GenericRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DigitalATMContext _context;
        public UnitOfWork(DigitalATMContext context)
        {
            _context = context;
            Accounts = new AccountRepository(_context);
            Clients = new ClientRepository(_context);
            Cards = new CardsRepository(_context);
            Deposits = new DepositRepository(_context);
            Loans = new LoansRepository(_context);
            Saving = new SavingRepository(_context);
            WithDraw = new WithdrawRepository(_context);
            Admin = new AdminRepository(_context);
        }
        public IClientRepository Clients { get; private set; }
        public IAccountRepository Accounts { get; private set; }
        public ILoansRepository Loans { get; private set; }
        public ICardRepository Cards { get; private set; }
        public IDepositRepository Deposits { get; private set; }
        public IWithDrawRepository WithDraw { get; private set; }
        public ISavingReposity Saving { get; private set; }

        public IAdminRepository Admin { get; private set; }


        public int Complete()
        {
           return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
