using FingerPrinter.Forms;
using System.Data.SQLite;
using System.IO;

namespace FingerPrinter
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }

        public static bool IsLoggedIn = false;
        public static string? LoggedInUser;
        public static bool isConnectedDevice = false;
        public static bool isAdminLogin = false;
        public static string imagePath = "../../../../icon";

    }
}