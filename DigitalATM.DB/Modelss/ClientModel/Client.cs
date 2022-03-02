using System;
using System.Collections.Generic;
using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss.ClientModel
{
    public partial class Client
    {
        public Client()
        {
            Accounts = new HashSet<Account>();
        }

        public int ClientId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Adress { get; set; }
        public string? City { get; set; }
        public int? HomeNumber { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
