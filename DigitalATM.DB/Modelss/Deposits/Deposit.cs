using System;
using System.Collections.Generic;
using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss.Deposits
{
    public partial class Deposit
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int? Amount { get; set; }
        public DateTime? DepositDate { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}
