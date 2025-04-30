using System;
using System.Windows.Forms;

namespace project
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Настройка приложения для использования визуальных компонентов Windows
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск формы TaskList (основного окна)
            Application.Run(new Form1());
        }
    }
}
