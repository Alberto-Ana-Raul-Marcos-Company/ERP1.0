using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NITRO_RAAM
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
            //Application.Run(new Login());

            /* Codigo que sirve para cerrar la ventana login 
             * y que no corra en un segundo plano y que no se 
             * cierre la app.
             * --
             * Pasaba esto por que al ser la ventana principal 
             * cada vez que se cerraba la app se detenia */
             
            //--
            Login main = new Login();
            main.FormClosed += Login_Closed;
            main.Show();
            Application.Run();
            //--

        }

        private static void Login_Closed(object sender, FormClosedEventArgs e)
        {
            //--
            ((Form)sender).FormClosed -= Login_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += Login_Closed;
            }
            //--
        }

    }
}
