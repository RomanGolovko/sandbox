using System;
using System.Windows.Forms;

namespace Garage.Presentation
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ChoosingDB dbChoice = new ChoosingDB();
            bool LiteDB = dbChoice.rbtn_LiteDB.Checked;
            bool MsSql = dbChoice.rbtn_mySQL.Checked; ;
            Application.Run(dbChoice);
        }
    }
}
