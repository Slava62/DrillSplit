using System;
using System.Windows.Forms;

namespace DrillSplit.Source
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
            //string temp=Environment.CurrentDirectory;
            Application.Run(new DRSMain());
        }
    }
}
