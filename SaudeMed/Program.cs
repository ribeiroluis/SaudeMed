using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SaudeMed
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmProdutos(19));
            Application.Run(new frmTelaSplash());
        }   
    }
}
