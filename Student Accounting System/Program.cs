using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize database
            try
            {
                DatabaseService.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось инициализировать базу данных:\n{ex.Message}\n\nПриложение будет закрыто.", 
                    "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Application.Run(new FormGroups());
        }
    }
}
