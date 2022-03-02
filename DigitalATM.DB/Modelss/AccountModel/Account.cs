using DigitalATM.DB.Modelss.ClientModel;
using DigitalATM.DB.Modelss.CreditCardModel;
using DigitalATM.DB.Modelss.Deposits;
using DigitalATM.DB.Modelss.Loans;
using DigitalATM.DB.Modelss.Savings;
using DigitalATM.DB.Modelss.Withdraw;
using System;
using System.Collections.Generic;

namespace DigitalATM.DB.Modelss.AccountModel
{
    public partial class Account
    {
        public Account()
        {
            AccountActions = new HashSet<AccountAction>();
            CreditCards = new HashSet<CreditCard>();
            Deposits = new HashSet<Deposit>();
            Loans = new HashSet<Loan>();
            Savings = new HashSet<Saving>();
            Transfers = new HashSet<Transfer>();
            WithDraws = new HashSet<WithDraw>();
        }

        public int AccountId { get; set; }
        public int Balance { get; set; }
        public int BankId { get; set; }
        public int BankAccNumber { get; set; }
        public int ClientId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual Bank Bank { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<AccountAction> AccountActions { get; set; }
        public virtual ICollection<CreditCard> CreditCards { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
        public virtual ICollection<Saving> Savings { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
        public virtual ICollection<WithDraw> WithDraws { get; set; }
    }
}
