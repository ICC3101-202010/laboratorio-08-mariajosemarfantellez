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
        public delegate bool CineEventHandler(object source, CineEventArgs args);
        public event EventHandler<CineEventArgs> CineG;
        public Form2()
        {
            InitializeComponent();
            OnCineG();
            
        }
        public void OnCineG()
        {
            if (CineG != null)
            {
                CineG(this, new CineEventArgs());
            }
        }
        public void CineCineG(string nombre, int numero, string horario, int salas)
        {
            TiendasRich.Text = "hola";
            CinesRich.Text += "Nombre del Dueño: " + nombre + "\n" + "Numero Identificador: " + numero + "\n " + "Horario de Atencion: " + horario + "\n" + "Cantidad de salas: " + salas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1.Show();
        }

    }
}
