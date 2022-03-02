using System;
using System.Collections.Generic;
using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss
{
    public partial class Transfer
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SendingAccountId { get; set; }
        public int RecivingAccountId { get; set; }
        public DateTime TransferDate { get; set; }
        public int Amount { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}
