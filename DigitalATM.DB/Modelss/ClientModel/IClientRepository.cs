using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss.ClientModel

{
    public interface IClientRepository
    {
        public void SaveChanges(Account account, int balance, int banknumber, string password, string username, string email, string fullname);
        public void UpdateAdress(Account account, string address, string city);
        void UpdatePassword(Account account, string password);
        void UpdateEmail(Account account, string email);
        void UpdatePhoneNumber(Account account, string phoneNumber);
        string GetThisUserPhoneNum(Account account);
        string GetThisUserEmailAdress(Account account);
        string GetThisUserCity(Account account);
        string GetThisUserAdress(Account account);
        List<Client> GetAllClients();

    }
}