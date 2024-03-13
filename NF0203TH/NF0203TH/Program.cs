using System.Data;

namespace NF0203TH
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
            DataTable dtAccount = new DataTable();
            bool resetTime = false;
            Application.Run(new Form1(dtAccount, resetTime));
        }
    }
}