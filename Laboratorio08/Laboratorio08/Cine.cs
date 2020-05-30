using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio08
{
    class Cine : Locales
    {
        private int numerosalas;
        public Cine (string NombreDueño, int Codigo, string Horario, int numerosalas) : base(NombreDueño,Codigo,Horario)
        {
            this.numerosalas = numerosalas;
        }
        public int NumeroSalas { get => numerosalas; set => numerosalas = value; }
    }
}
