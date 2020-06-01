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
            Form2 form = new Form2();
            ControlTienda controltienda = new ControlTienda(appForm, form);
            ControlCine controlcine = new ControlCine(appForm, form);
            ControlRestaurante controlrestaurante = new ControlRestaurante(appForm,form);
            ControlRecreacional controlrecreacional = new ControlRecreacional(appForm,form);
            
            Application.Run(appForm);
            Application.Run(form);
        }
    }
}
