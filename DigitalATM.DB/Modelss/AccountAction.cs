using DigitalATM.DB.Modelss.AccountModel;
using System;
using System.Collections.Generic;

namespace DigitalATM.DB.Modelss
{
    public partial class AccountAction
    {
        public int Id { get; set; }
        public int? ActionId { get; set; }
        public int AccountId { get; set; }
        public int Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}
