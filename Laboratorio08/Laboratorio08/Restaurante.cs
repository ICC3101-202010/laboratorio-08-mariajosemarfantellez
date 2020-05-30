using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio08
{
    class Restaurante : Locales
    {
        private string mesas;
        public Restaurante(string NombreDueño, int Codigo, string Horario, string mesas) : base(NombreDueño,Codigo,Horario)
        {
            this.mesas = mesas;
        }
        public string Mesas { get => mesas; set => mesas = value; }
    }
}
