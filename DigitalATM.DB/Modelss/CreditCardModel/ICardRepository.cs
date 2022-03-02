using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss.AccountModel;


namespace DigitalATM.DB.Modelss.CreditCardModel
{
    public interface ICardRepository : IGenericRepository<CreditCard>
    {
        void DeleteCreditCard(int creditCardNumber);
        void CreateNewCreditCard(Account account);
        string CreateAndReturnCreditCard(Account account);
        int GetThisUserCardsCount(Account account);
        CreditCard GetThisCard(Account Account);
        CreditCard GetThisCard(int CardId);
        List<int> GetCards();

    }
}