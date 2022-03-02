using System;
using System.Collections.Generic;
using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss.Savings
{
    public partial class Saving
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public DateTime StartDate { get; set; }
        public int Amount { get; set; }
        public string? SaveName { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}
