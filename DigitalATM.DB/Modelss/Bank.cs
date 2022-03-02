using System;
using System.Collections.Generic;
using DigitalATM.DB.Modelss.AccountModel;

using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss
{
    public partial class Bank
    {
        public Bank()
        {
            Accounts = new HashSet<Account>();
        }

        public int BankId { get; set; }
        public string? BankName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
