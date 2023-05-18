using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartaBeremenosti
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // "Database=ambkarti1;Data Source=localhost;Port=3306;User Id=root;Password=Mamcita;charset = utf8;Connection Timeout=10;Min Pool Size=1;Max Pool Size=150;Pooling=true; Allow User Variables = True"
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1("Админ_АА", 1, "Центр", 1, 1, 2, "Database=ambkarti1;Data Source=localhost;Port=3306;User Id=root;Password=mamacita;charset = utf8;Connection Timeout=10;Min Pool Size=1;Max Pool Size=150;Pooling=true; Allow User Variables = True"));
        }
    }
}
