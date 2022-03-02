using DigitalATM.DB.Modelss.AccountModel;
using System;
using System.Collections.Generic;


namespace DigitalATM.DB.Modelss.CreditCardModel
{
    public partial class CreditCard
    {
        public int CardId { get; set; }
        public int? CardNumber { get; set; }
        public DateTime? CardExpiredDate { get; set; }
        public int? CardCvv { get; set; }
        public string? CardHolder { get; set; }
        public int? AccountId { get; set; }

        public virtual Account? Account { get; set; }
    }
}
