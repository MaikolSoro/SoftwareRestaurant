using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaRestaurant
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GUI.Login.LoginForm frm = new GUI.Login.LoginForm();
            frm.FormClosed += frm_closed;
            frm.ShowDialog();
            Application.Run();
        }
        private static void frm_closed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
