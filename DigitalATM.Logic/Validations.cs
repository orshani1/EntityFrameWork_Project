using DigitalATM.DB.Modelss;
using System.Text.RegularExpressions;

namespace DigitalATM.Logic
{
   /// <summary>
   ///  Validations class 
   /// </summary>
    public static class Validations
    {
                               
        public static bool IsUserName(string username)
        {


            foreach (var letter in username)
            {
                if (char.IsSymbol(letter))
                {
                    return false;
                }
                if (char.IsWhiteSpace(letter))
                {
                    return false;
                }


            }
            if (username.Length < 6)
            {
                return false;
            }

            return true;
        }
        public static bool IsLegitPassword(string password)
        {
            int countUpper = 0;
            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    countUpper++;
                }
                if (char.IsSymbol(item))
                {
                    return false;
                }
            }
            if (countUpper == 0)
            {
                return false;
            }
            return true;
        }
        public static bool IsLegitEmail(string email)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (regex.IsMatch(email))
            {
                return true;
            }


            return false;
            
        }
        public static bool IsAdressEmpty(string addres)
        {
            if (addres.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsLegitPhoneNumber(string phoneNum)
        {
            var digits = phoneNum.ToArray();
            foreach (var item in phoneNum)
            {
                if (!char.IsDigit(item))
                {
                    return false;
                }
                if (digits[0] != '0')
                {
                    return false;
                }
            } 
                return true;
        }
        public static bool IsAlreadyExsistUserName(string userName)
        {
            using (var db = new DigitalATMContext())
            {
                var checkForUserName = db.Accounts.Where(c=>c.UserName == userName).
                    Select(c => c).ToArray();
                if (checkForUserName.Length == 0)
                    return false;
            }

            return true;
        }

    }
}