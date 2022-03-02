using DigitalATM.DB;

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
            Application.Run(new LoginMenu());
        }
    }
}