using DigitalATM.DB.Modelss.AccountModel;

namespace DigitalATM.DB.Modelss.Savings
{
    public interface ISavingReposity
    {
        void CreateNewSaving(Account account, int amount, string name);
        Saving GetSaving(string savingName);
    }
}