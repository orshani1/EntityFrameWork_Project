using DigitalATM.DB.Interfaces;

namespace DigitalATM.DB.Modelss
{
    public interface IAdminRepository : IGenericRepository<Admin>
    {
        void AdjustAdmin();
    }
}