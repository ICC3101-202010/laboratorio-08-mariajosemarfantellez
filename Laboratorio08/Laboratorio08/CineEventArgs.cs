using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio08
{
    public class CineEventArgs : EventArgs
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public string Horarios { get; set; }
        public int Salas { get; set; }
    }

}
