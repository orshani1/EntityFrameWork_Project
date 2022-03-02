using DigitalATM.DB.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DigitalATM.DB
{
    public class DataBaseValidations
    {
        public static bool IsUserExsists(string usernameInput, string passwordInput)
        {
            using (var DB = new DigitalATMContext())
            {
                var account = DB.Accounts.Where(c => c.UserName == usernameInput && c.Password == passwordInput).Select(a => a).FirstOrDefault();
                if (account != null)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool IsUserExsists(string usernameInput)
        {
            using (var db = new DigitalATMContext())
            {
                var clients = db.Accounts.
                    Where(c => c.UserName == usernameInput).
                    Select(c => new { c.UserName, c.Password });
                var finalClient = clients.ToList();
                foreach (var field in finalClient)
                {
                    if (field.UserName == usernameInput)
                    {
                        return true;
                    }
                }
                return false;

            }
        }



    }
}


