using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio08
{
    class Locales
    {
        private string nombredueño;
        private int codigo;
        private string horario;
        public Locales(string nombredueño, int codigo, string horario)
        {
            this.nombredueño = nombredueño;
            this.codigo = codigo;
            this.horario = horario;
        }
        public string NombreDueño { get => nombredueño; set => nombredueño = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Horario { get => horario; set => horario = value; }
    }
}
