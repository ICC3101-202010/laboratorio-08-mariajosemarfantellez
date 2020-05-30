using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio08
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 appForm = new Form1();
            ControlTienda controltienda = new ControlTienda(appForm);
            ControlCine controlcine = new ControlCine(appForm);
            ControlRestaurante controlrestaurante = new ControlRestaurante(appForm);
            ControlRecreacional controlrecreacional = new ControlRecreacional(appForm);
            Application.Run(appForm);
        }
    }
}
