using System;
using System.Collections.Generic;
using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss.Withdraw
{
    public partial class WithDraw
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int? Amount { get; set; }
        public DateTime? WithdrawDate { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}
