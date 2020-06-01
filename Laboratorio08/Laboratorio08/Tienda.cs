using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio08
{
    public class Tienda : Locales
    {
        private string categoriatienda;

        public Tienda (string NombreDueño, int Codigo, string Horario, string categoriatienda) : base(NombreDueño,Codigo,Horario)
        {
            this.categoriatienda = categoriatienda;
        }

        public string CategoriaTienda { get => categoriatienda; set => categoriatienda = value; }
    }
}
