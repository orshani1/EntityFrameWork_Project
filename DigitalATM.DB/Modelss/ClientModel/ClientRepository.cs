using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Modelss.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalATM.DB.Modelss.ClientModel
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(DigitalATMContext context) : base(context)
        {

        }

        public List<Client> GetAllClients()
        {
            using (var db = new DigitalATMContext())
            {
                var list = db.Clients.ToList();
                return list;
            }
        }

        public string GetThisUserAdress(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                var adress = db.Clients.Where(c => c.ClientId == account.ClientId).
                    Select(c => c.Adress).FirstOrDefault();
                return adress;
            }
        }
        public string GetThisUserCity(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                var adress = db.Clients.Where(c => c.ClientId == account.ClientId).
                    Select(c => c.City).FirstOrDefault();
                return adress;
            }
        }
        public string GetThisUserEmailAdress(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                var emailAdress = db.Clients.Where(c => c.ClientId == account.ClientId).
                    Select(c => c.Email).FirstOrDefault();
                if (emailAdress != null)
                {

                    return emailAdress;
                }
                else
                {

                    return "null";
                }
            }
        }
        public string GetThisUserPhoneNum(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                var phoneNum = db.Clients.Where(c => c.ClientId == account.ClientId).
                    Select(c => c.PhoneNumber).FirstOrDefault();
                return phoneNum;

            }
        }


        public void SaveChanges(Account account, int balance, int banknumber, string password, string username, string email, string fullname)
        {
            using (var db = new DigitalATMContext())
            {
                var client = db.Clients.Where(c => c.ClientId == account.ClientId).
                        Select(c => c).FirstOrDefault();
                account.Balance = balance;
                account.BankAccNumber = banknumber;
                account.Password = password;
                account.UserName = username;
                client.FirstName = fullname.Split()[0];
                client.LastName = fullname.Split()[1];
                client.Email = email;
                db.Accounts.Update(account);
                db.SaveChanges();

            }
        }
        public void UpdateAdress(Account account, string address, string city)
        {
            using (var db = new DigitalATMContext())
            {
                var newAcc = db.Clients.Where(c => c.ClientId == account.ClientId).
                    Select(c => c).FirstOrDefault();
                if (newAcc != null)
                {
                    newAcc.Adress = address;
                    newAcc.City = city;
                    db.SaveChanges();
                }

            }
        }
        public void UpdateEmail(Account account, string email)
        {
            using (var db = new DigitalATMContext())
            {
                var acc = db.Clients.Where(c => c.ClientId == account.ClientId).
                    Select(c => c).FirstOrDefault();
                if (acc != null)
                {
                    acc.Email = email;
                    db.SaveChanges();
                }
            }
        }
        public void UpdatePassword(Account account, string password)
        {
            using (var db = new DigitalATMContext())
            {
                var Acc = db.Accounts.Where(a => a.AccountId == account.AccountId).
                    Select(a => a).FirstOrDefault();
                if (Acc != null)
                {

                    Acc.Password = password;
                    db.SaveChanges();
                }

            }
        }
        public void UpdatePhoneNumber(Account account, string phoneNumber)
        {
            using (var db = new DigitalATMContext())
            {
                var acc = db.Clients.Where(c => c.ClientId == account.ClientId).
                    Select(c => c).FirstOrDefault();
                if (acc != null)
                {
                    acc.PhoneNumber = phoneNumber;
                    db.SaveChanges();
                }
            }
        }
    }
}
