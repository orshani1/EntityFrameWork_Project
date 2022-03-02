using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss.Withdraw
{
    public interface IWithDrawRepository
    {
        void CreateNewWithDraw(Account account, int amount);

    }
}