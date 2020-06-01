using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio08
{
    public partial class Form2 : Form
    {
        public delegate List<Cine> CineEventHandler(object source, CineEventArgs args);
        public event CineEventHandler CineG;
        public delegate List<Tienda> TiendaEventHandler(object source, TiendaEventArgs args);
        public event TiendaEventHandler TiendaG;
        public delegate List<Recreacional> RecreacionalEventHandler(object source, RecreacionalEventArgs args);
        public event RecreacionalEventHandler RecG;
        public delegate List<Restaurante> RestauranteEventHandler(object source, RestauranteEventArgs args);
        public event RestauranteEventHandler RestG;


        public Form2()
        {
            InitializeComponent();  
        }
        public void OnCineG()
        {
            if (CineG != null)
            {
                List<Cine> cine = CineG(this, new CineEventArgs() { });
                foreach (Cine i in cine)
                {
                    CinesRich.Text = CinesRich.Text + "\n" + "Nombre del Dueño: " + i.NombreDueño + "\n" + "Numero Identificador: " + i.Codigo + "\n " + "Horario de Atencion: " + i.Horario + "\n" + "Cantidad de salas: " + i.NumeroSalas + "\n";
                }
            }
        }
        public void OnTiendaG()
        {
            if (TiendaG != null)
            {
                List<Tienda> tienda = TiendaG(this, new TiendaEventArgs() { });
                foreach (Tienda i in tienda)
                {
                    TiendasRich.Text = TiendasRich.Text + "\n" + "Nombre del Dueño: " + i.NombreDueño + "\n" + "Numero Identificador: " + i.Codigo + "\n " + "Horario de Atencion: " + i.Horario + "\n" + "Categoria(s): " + i.CategoriaTienda + "\n";
                }
            }
        }
        public void OnRecG()
        {
            if (RecG != null)
            {
                List<Recreacional> rec = RecG(this, new RecreacionalEventArgs() { });
                foreach (Recreacional i in rec)
                {
                    RecRich.Text = RecRich.Text + "\n" + "Nombre del Dueño: " + i.NombreDueño + "\n" + "Numero Identificador: " + i.Codigo + "\n " + "Horario de Atencion: " + i.Horario + "\n";
                }
            }
        }
        public void OnRestG()
        {
            if (RestG != null)
            {
                List<Restaurante> rest = RestG(this, new RestauranteEventArgs() { });
                foreach (Restaurante i in rest)
                {
                    RestRich.Text = RestRich.Text + "\n" + "Nombre del Dueño: " + i.NombreDueño + "\n" + "Numero Identificador: " + i.Codigo + "\n " + "Horario de Atencion: " + i.Horario + "\n" + "Contiene mesas exclusivas: " + i.Mesas + "\n";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CinesExistentesButton_Click(object sender, EventArgs e)
        {
            OnCineG();
        }

        private void TiendasExistentesButton_Click(object sender, EventArgs e)
        {
            OnTiendaG();
        }

        private void RestauranteExistenteButton_Click(object sender, EventArgs e)
        {
            OnRestG();
        }

        private void RecExistentesButton_Click(object sender, EventArgs e)
        {
            OnRecG();
        }
    }
}
