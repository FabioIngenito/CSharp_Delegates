using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referências
//http://msdn.microsoft.com/pt-br/library/900fyy8e.aspx
//http://msdn.microsoft.com/pt-br/library/system.delegate.aspx

namespace waDelegates
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDelegates());
        }
    }
}
