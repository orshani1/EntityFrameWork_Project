using DigitalATM.DB;
using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Modelss;

namespace DigitalATM.UI
{
    internal static class Program
    {
       
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DataBaseInitilazition.InitDB();
            var _context = new DigitalATMContext();
            var unit = new UnitOfWork(_context);
            unit.Admin.AdjustAdmin();
            Application.Run(new LoginMenu());

        }
    }
}