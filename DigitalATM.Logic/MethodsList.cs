using DigitalATM.DB;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss;
using DigitalATM.DB.Modelss.AccountModel;
using System.Data;
using System.Diagnostics;
using System.Net.Mail;

namespace DigitalATM.Logic
{
    #region DBSCAFFOLDCOMMAND
    /*
     Scaffold-DbContext "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models 

    */
    #endregion
    public  class MethodList: IEmailManagment 
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public DigitalATMContext context { get; set; } = new DigitalATMContext();   
        private static MethodList _instance { get; set; }
        private MethodList()
        {
            UnitOfWork = new UnitOfWork(context);
        }
        public  int randomCode { get; set; }
        public  void SendCodeThroughEmail(string? emailAdress, string subject, string body, string code)
        {

            string from = "ortheog@gmail.com";
            if (emailAdress != null)
            {


                MailMessage mail = new MailMessage(from, emailAdress);
                using (SmtpClient smtpclient = new SmtpClient())
                {
                    smtpclient.Port = 587;
                    smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpclient.UseDefaultCredentials = false;
                    smtpclient.Host = "smtp.gmail.com";
                    smtpclient.UseDefaultCredentials = false;
                    mail.Subject = subject;
                    mail.Body = body + "\n" + code;
                    smtpclient.EnableSsl = true;
                    smtpclient.Credentials = new System.Net.NetworkCredential()

                    {
                        UserName = "ortheog@gmail.com",
                        Password = "or3577530159753"
                    };
                    smtpclient.Send(mail);
                }
            }



        }
        public  void SendMessageThroughEmail(string? emailAdress, string subject, string body)
        {
            var randomnum = new Random();
            var code = string.Empty;
            for (int i = 0; i < 6; i++)
            {
                var finalDigit = randomnum.Next(0, 11);
                code += finalDigit.ToString();
            }
            randomCode = int.Parse(code);
            string from = "ortheog@gmail.com";
            if (emailAdress != null)
            {


                MailMessage mail = new MailMessage(from, emailAdress);
                using (SmtpClient smtpclient = new SmtpClient())
                {
                    smtpclient.Port = 587;
                    smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpclient.UseDefaultCredentials = false;
                    smtpclient.Host = "smtp.gmail.com";
                    smtpclient.UseDefaultCredentials = false;
                    mail.Subject = subject;
                    mail.Body = body;
                    smtpclient.EnableSsl = true;
                    smtpclient.Credentials = new System.Net.NetworkCredential()

                    {
                        UserName = "ortheog@gmail.com",
                        Password = "or3577530159753"
                    };
                    smtpclient.Send(mail);
                }
            }
        }
        public  void SendAccountDetailsThroughEmail(Account account)
        {
            using (var db = new DigitalATMContext())
            {
                var bank = db.Banks.Where(b => b.BankId == account.BankId).
                    Select(b => b.BankName).FirstOrDefault();
                if (bank != null)
                {
                    var subject = "DigitalATM Account Details";
                    var body = $"Welcome {account.Client.FirstName}\nHere is the list of your AccountDetails\n" +
                        $"username :{account.UserName}\npasssword:{account.Password}\nBank : {bank.ToString()}\n" +
                        $"Credit card details:\nCardnumber:{account.CreditCards.FirstOrDefault().CardNumber}\nCardCCV:{account.CreditCards.FirstOrDefault().CardCvv}\n" +
                        $"Expire date :{account.CreditCards.FirstOrDefault().CardExpiredDate}\nCard Holder {account.CreditCards.FirstOrDefault().CardHolder}";

                    string from = "ortheog@gmail.com";
                   
                    if (account.Client.Email != null)
                    {


                        MailMessage mail = new MailMessage(from, account.Client.Email);
                        using (SmtpClient smtpclient = new SmtpClient())
                        {
                            smtpclient.Port = 587;
                            smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtpclient.UseDefaultCredentials = false;
                            smtpclient.Host = "smtp.gmail.com";
                            smtpclient.UseDefaultCredentials = false;
                            mail.Subject = subject;
                            mail.Body = body;
                            smtpclient.EnableSsl = true;
                            smtpclient.Credentials = new System.Net.NetworkCredential()

                            {
                                UserName = "ortheog@gmail.com",
                                Password = "or3577530159753"
                            };
                            smtpclient.Send(mail);
                        }
                    }
                }
            }
        }

        public  void SendHelloNewUser(string emailAdress, string nameOrUserName)
        {
            var subject = "DigitalATM: Hello New User!";
            var body = $"Hello Dear {nameOrUserName}\nWelcome to our Services From today you will be joining everyday experience\n" +
                $"with our didgital atm software\n\n\nHope you Enjoy your time your dear ATM Robot. Jaskier";

            var randomnum = new Random();
            var code = string.Empty;
            for (int i = 0; i < 6; i++)
            {
                var finalDigit = randomnum.Next(0, 11);
                code += finalDigit.ToString();
            }
            randomCode = int.Parse(code);
            string from = "ortheog@gmail.com";

            MailMessage mail = new MailMessage(from, emailAdress);
            using (SmtpClient smtpclient = new SmtpClient())
            {
                smtpclient.Port = 587;
                smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpclient.UseDefaultCredentials = false;
                smtpclient.Host = "smtp.gmail.com";
                smtpclient.UseDefaultCredentials = false;
                mail.Subject = subject;
                mail.Body = body;
                smtpclient.EnableSsl = true;
                smtpclient.Credentials = new System.Net.NetworkCredential()

                {
                    UserName = "ortheog@gmail.com",
                    Password = "or3577530159753"
                };
                smtpclient.Send(mail);
            }
        }
        public  void SendCodeSms()
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(@"cd C:\Users\user\Desktop\softwaredev\Projects Folder\DigitalATMProject\SendSms");
                    sw.WriteLine("main.py");

                }
            }
        }
        public string SendPasswordThroughEmail(string emailAdress, string userName)
        {

            string from = "ortheog@gmail.com";

            MailMessage mail = new MailMessage(from, emailAdress);
            using (SmtpClient smtpclient = new SmtpClient())
            {
                smtpclient.Port = 587;
                smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpclient.UseDefaultCredentials = false;
                smtpclient.Host = "smtp.gmail.com";
                smtpclient.UseDefaultCredentials = false;
                mail.Subject = "Digital ATM New Password";
                mail.Body = $"Dear {userName} As you requsted we Restored your password is:\n\n\n\nRestoredPassword123";
                smtpclient.EnableSsl = true;
                smtpclient.Credentials = new System.Net.NetworkCredential()

                {
                    UserName = "ortheog@gmail.com",
                    Password = "or3577530159753"
                };
                UnitOfWork = new UnitOfWork(context);
                UnitOfWork.Accounts.RestorePassword(userName);
                smtpclient.Send(mail);
                return "Password Restored Succsesfully\nYou will recieve an email with the details in a short time.";


            }




        }
        public string SendCodeThroughEmail(string emailAdress, string userName)
        {
            var randomnum = new Random();
            var code = string.Empty;
            for (int i = 0; i < 6; i++)
            {
                var finalDigit = randomnum.Next(0, 11);
                code += finalDigit.ToString();
            }
            randomCode = int.Parse(code);
            string from = "ortheog@gmail.com";

            MailMessage mail = new MailMessage(from, emailAdress);
            using (SmtpClient smtpclient = new SmtpClient())
            {
                smtpclient.Port = 587;
                smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpclient.UseDefaultCredentials = false;
                smtpclient.Host = "smtp.gmail.com";
                smtpclient.UseDefaultCredentials = false;
                mail.Subject = "Digital ATM Restore Password with Code";
                mail.Body = $"Dear {userName} As you requsted we Genrated a random code for you insert the code in the Software Textbox\n\n\n\nThe Code : {code}";
                smtpclient.EnableSsl = true;
                smtpclient.Credentials = new System.Net.NetworkCredential()

                {
                    UserName = "ortheog@gmail.com",
                    Password = "or3577530159753"
                };
                smtpclient.Send(mail);
            }

            return code;

        }
        public static MethodList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MethodList();
               return _instance;    
            }
           return _instance;
        }//SingleTone DesignPattern

        public void SendAllUsersMessage(string subject,string body)
        {
            using (var db = new DigitalATMContext())
            {
                var emailsAdresses = db.Clients.Select(c => c.Email).ToList();
                foreach (var adress in emailsAdresses)
                {
                    SendMessageThroughEmail(adress,subject,body);
                }
            }
        }
    }
}

