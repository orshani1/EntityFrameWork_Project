using DigitalATM.DB.Modelss.AccountModel;
using System;
using System.Collections.Generic;

namespace DigitalATM.DB.Modelss.Loans
{
    public partial class Loan
    {
        public int Id { get; set; }
        public int? Amount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? DepositAmount { get; set; }
        public int? AccountId { get; set; }

        public virtual Account? Account { get; set; }
    }
}
