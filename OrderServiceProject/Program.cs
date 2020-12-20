using OrderServiceProject.Services;
using OrderServiceProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderServiceProject
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
            var context = new GlobalContextService();
            var singInView = new SingInView(context);
            Application.Run(singInView);
        }
    }
}
