using DigitalATM.DB.GenericRepository;


namespace DigitalATM.DB.Modelss
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(DigitalATMContext context) : base(context)
        {

        }
        public void AdjustAdmin()
        {
            using (var db = _context)
            {
                var isAdmin = db.Admins.Any();
                if (isAdmin == null)
                {

                    var account = db.Accounts.Select(a => a).First();
                    var admin = new Admin()
                    {
                        AccountId = account.AccountId,

                    };
                    db.Admins.Add(admin);
                    db.SaveChanges();
                }
            }
        }
    }
}
