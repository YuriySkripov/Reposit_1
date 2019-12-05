using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        public static string st_connect= @"Data Source=ASUS-PC\SQLEXPRESS;Initial Catalog = FitnessClub; Integrated Security = True";
        public static int ID_Users = -1;
        
        public static bool type_user = false;
            [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
