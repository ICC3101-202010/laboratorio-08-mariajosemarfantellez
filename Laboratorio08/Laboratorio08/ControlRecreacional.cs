using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Laboratorio08
{
    class ControlRecreacional
    {
        //metodos de recreacional, sus eventos
        List<Recreacional> recreacionales = new List<Recreacional>();
        Form1 view;
        public ControlRecreacional(Form view)
        {
            ReInitialize();
            this.view = view as Form1;
            this.view.RecreacionalCreate += OnRecreacionalCreate;
        }
        public void ReInitialize()
        {
            recreacionales.Add(new Recreacional("Jose Tomas", 340, "3:00-18:00"));
            recreacionales.Add(new Recreacional("Maria Jose", 450, "6:00-00:00"));
        }
        public bool OnRecreacionalCreate(object sender, RecreacionalEventArgs e)
        {
            foreach (Recreacional t in recreacionales)
            {
                if (t.NombreDueño == e.Nombre && t.Codigo == e.Numero)
                {
                    return false;
                }
            }
            recreacionales.Add(new Recreacional(e.Nombre, e.Numero, e.Horarios));
            return true;
        }
    }
}
