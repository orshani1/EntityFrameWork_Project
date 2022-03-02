using DigitalATM.DB.Modelss.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalATM.Logic
{
    public interface IEmailManagment
    {
        void SendCodeSms();
        void SendHelloNewUser(string emailAdress, string nameOrUserName);
        void SendAccountDetailsThroughEmail(Account account);
        void SendMessageThroughEmail(string? emailAdress, string subject, string body);
        void SendCodeThroughEmail(string? emailAdress, string subject, string body, string code);
        string SendCodeThroughEmail(string emailAdress, string userName);
        string SendPasswordThroughEmail(string emailAdress, string userName);
        void SendAllUsersMessage(string subject,string body);
    }
}
