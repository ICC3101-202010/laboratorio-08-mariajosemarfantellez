using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Laboratorio08
{
    public partial class Form1 : Form
    {
        /*
        private void Save()
        {
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\info.bin"));
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, ControlCine.cines);
            formatter.Serialize(stream, mediaPlayer.Songs);
            formatter.Serialize(stream, mediaPlayer.Karaokes);
            formatter.Serialize(stream, mediaPlayer.Videos);
            formatter.Serialize(stream, mediaPlayer.Series);
            stream.Close();
        }
        */

        public delegate bool CineEventHandler(object source, CineEventArgs args);
        public event CineEventHandler CineCreate;
        public event EventHandler<CineEventArgs> InfoCine;
        public delegate bool RestauranteEventHandler(object source, RestauranteEventArgs args);
        public event RestauranteEventHandler RestauranteCreate;
        public event EventHandler<RestauranteEventArgs> InfoRestaurante;
        public delegate bool RecreacionalEventHandler(object source, RecreacionalEventArgs args);
        public event RecreacionalEventHandler RecreacionalCreate;
        public event EventHandler<RecreacionalEventArgs> InfoRecreacional;
        public delegate bool TiendaEventHandler(object source, TiendaEventArgs args);
        public event TiendaEventHandler TiendaCreate;
        public event EventHandler<TiendaEventArgs> InfoTienda;

        public Form1()
        {
            InitializeComponent();
            PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;

            /*
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\info.bin"));
            if (File.Exists(path))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                Gate.Users = (List<User>)formatter.Deserialize(stream);
                mediaPlayer.Songs = (List<Song>)formatter.Deserialize(stream);
                mediaPlayer.Karaokes = (List<Karaoke>)formatter.Deserialize(stream);
                mediaPlayer.Videos =(List<Video>)formatter.Deserialize(stream);
                mediaPlayer.Series = (List<Serie>)formatter.Deserialize(stream);
                stream.Close();
            } 
             
             */
        }

        private void AgregarLocalButton_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Visible = false;
            AgregarLocalPanel.Visible = true;
            AgregarLocalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void CrearCineButton_Click(object sender, EventArgs e)
        {
            AgregarLocalPanel.Visible = false;
            CineCreatePanel.Visible = true;
            CineCreatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void OnCineCreate(string name, int codificador, string hor, int sala)
        {
            if (CineCreate != null)
            {
                bool result = CineCreate(this, new CineEventArgs() { Nombre = name, Numero = codificador, Horarios = hor, Salas = sala });
                if (result == false)
                {
                    CineCreadoOnoTextBox.Text = "Ese cine ya existe";
                    CineNombreDueñoTextBox.Text = " ";
                    CineNumeroIdentificadorTextBox.Text = " ";
                    CineHorarioTextBox.Text = " ";
                    CineSalasTextBox.Text = " ";
                }
                else
                {
                    CineCreadoOnoTextBox.Text = " ";
                    CineNombreDueñoTextBox.Text = " ";
                    CineNumeroIdentificadorTextBox.Text = " ";
                    CineHorarioTextBox.Text = " ";
                    CineSalasTextBox.Text = " ";
                    CineCreatePanel.Visible = false;
                    PanelPrincipal.Visible = true;
                    PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
                }
            }
        }

        private void CineCrearButton_Click(object sender, EventArgs e)
        {
            string nombredueño = CineNombreDueñoTextBox.Text;
            bool numcheck = false;
            int numero;
            numcheck = int.TryParse(CineNumeroIdentificadorTextBox.Text, out numero);
            string horario = CineHorarioTextBox.Text;
            bool numchecks = false;
            int salas;
            numchecks = int.TryParse(CineSalasTextBox.Text, out salas);
            if (numcheck && numchecks)
            {
                OnCineCreate(nombredueño, numero, horario, salas);
            }
            else
            {
                CineCreadoOnoTextBox.Text = "Formato invalido";
            }
            
        }

        private void CrearRestauranteButton_Click(object sender, EventArgs e)
        {
            AgregarLocalPanel.Visible = false;
            RestaurantePanel.Visible = true;
            RestaurantePanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void RestCrearButton_Click(object sender, EventArgs e)
        {
            string nombredueño = RestNombreDueñoTextBox.Text;
            bool numcheck = false;
            int numero;
            numcheck = int.TryParse(RestNumeroTextBox.Text, out numero);
            string horario = RestHorarioTextBox.Text;
            string mesas = RestMesasTextBox.Text;
            if (numcheck)
            {
                OnRestauranteCreate(nombredueño, numero, horario, mesas);
            }
            else
            {
                RestExistTextBox.Text = "Formato invalido";
            }
        }
        private void OnRestauranteCreate(string name, int codificador, string hor, string mesas)
        {
            if (RestauranteCreate != null)
            {
                bool result = RestauranteCreate(this, new RestauranteEventArgs() { Nombre = name, Numero = codificador, Horarios = hor, MesasExclusivas = mesas });
                if (result == false)
                {
                    RestExistTextBox.Text = "Ese restaurante ya existe";
                    RestNombreDueñoTextBox.Text = " ";
                    RestNumeroTextBox.Text = " ";
                    RestHorarioTextBox.Text = " ";
                    RestMesasTextBox.Text = " ";
                }
                else
                {
                    RestExistTextBox.Text = " ";
                    RestNombreDueñoTextBox.Text = " ";
                    RestNumeroTextBox.Text = " ";
                    RestHorarioTextBox.Text = " ";
                    RestMesasTextBox.Text = " ";
                    RestaurantePanel.Visible = false;
                    PanelPrincipal.Visible = true;
                    PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
                }
            }
        }

        private void RecCrearButton_Click(object sender, EventArgs e)
        {
            string nombredueño = RecNombreDueñoTextBox.Text;
            bool numcheck = false;
            int numero;
            numcheck = int.TryParse(RecNumeroTextBox.Text, out numero);
            string horario = RecHorarioTextBox.Text;
            if (numcheck)
            {
                OnRecreacionalCreate(nombredueño, numero, horario);
            }
            else
            {
                RecExistTextBox.Text = "Formato invalido";
            }
        }
        private void OnRecreacionalCreate(string name, int codificador, string hor)
        {
            if (RecreacionalCreate != null)
            {
                bool result = RecreacionalCreate(this, new RecreacionalEventArgs() { Nombre = name, Numero = codificador, Horarios = hor});
                if (result == false)
                {
                    RecExistTextBox.Text = "Ese centro recreacional ya existe";
                    RecNombreDueñoTextBox.Text = " ";
                    RecNumeroTextBox.Text = " ";
                    RecHorarioTextBox.Text = " ";
                }
                else
                {
                    RecExistTextBox.Text = " ";
                    RecNombreDueñoTextBox.Text = " ";
                    RecNumeroTextBox.Text = " ";
                    RecHorarioTextBox.Text = " ";
                    RecPanel.Visible = false;
                    PanelPrincipal.Visible = true;
                    PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
                }
            }
        }

        private void CrearRecreacionalButton_Click(object sender, EventArgs e)
        {
            AgregarLocalPanel.Visible = false;
            RecPanel.Visible = true;
            RecPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void TiendaCrearbutton_Click(object sender, EventArgs e)
        {
            string nombredueño = TiendaNombreDueñoTextBox.Text;
            bool numcheck = false;
            int numero;
            numcheck = int.TryParse(TiendaNumeroTextBox.Text, out numero);
            string horario = TiendaTiendaHorarioTextBox.Text;
            string categoria = TiendaCategoriaTextBox.Text;
            if (numcheck)
            {
                OnTiendaCreate(nombredueño, numero, horario, categoria);
            }
            else
            {
                TiendaExistTextBox.Text = "Formato invalido";
            }
        }
        private void OnTiendaCreate(string name, int codificador, string hor, string categoria)
        {
            if (TiendaCreate != null)
            {
                bool result = TiendaCreate(this, new TiendaEventArgs() { Nombre = name, Numero = codificador, Horarios = hor, Categorias = categoria });
                if (result == false)
                {
                    TiendaExistTextBox.Text = "Esa tienda ya existe";
                    TiendaNombreDueñoTextBox.Text = " ";
                    TiendaNumeroTextBox.Text = " ";
                    TiendaTiendaHorarioTextBox.Text = " ";
                    TiendaCategoriaTextBox.Text = " ";
                }
                else
                {
                    TiendaExistTextBox.Text = " ";
                    TiendaNombreDueñoTextBox.Text = " ";
                    TiendaNumeroTextBox.Text = " ";
                    TiendaTiendaHorarioTextBox.Text = " ";
                    TiendaCategoriaTextBox.Text = " ";
                    TiendaPanel.Visible = false;
                    PanelPrincipal.Visible = true;
                    PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
                }
            }
        }

        private void CrearTiendaButton_Click(object sender, EventArgs e)
        {
            AgregarLocalPanel.Visible = false;
            TiendaPanel.Visible = true;
            TiendaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void RevisarInformacionButton_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Visible = false;
            RevisarLocalPanel.Visible = true;
            RevisarLocalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void RevisarInfoTiendaButton_Click(object sender, EventArgs e)
        {
            RevisarLocalPanel.Visible = false;
            TiendaInfoPanel.Visible = true;
            TiendaInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void TiendaVerbutton_Click(object sender, EventArgs e)
        {
            string nombredueño = TiendaInfoDueñoTextBox.Text;
            bool numcheck = false;
            int numero;
            numcheck = int.TryParse(TiendaInfoNumeroTextBox.Text, out numero);
            

            if (numcheck)
            {
                OnInfoTienda(nombredueño, numero);
                
            }
            else
            {
                TiendaInfoExistTextBox.Text = "Esa tienda no existe";
            }
        }
        private void OnInfoTienda(string nombredueño, int numero)
        {
            if (InfoTienda != null)
            {
                InfoTienda(this, new TiendaEventArgs() { Nombre = nombredueño, Numero = numero });
            }
        }
        public void NoTienda()
        {
            TiendaInfoExistTextBox.Text = "Esa tienda no existe";
        }
        public void NoCine()
        {
            CineInfoExistTextBox.Text = "Ese cine no existe";
        }
        public void NoRest()
        {
            RestInfoExistTextrBox.Text = "Ese restaurante no existe";
        }
        public void NoRec()
        {
            RecInfoExistTextBox.Text = "Ese centro recreacional no existe";
        }

        public void TiendaInfo(string nombre, int num, string horario, string categoria)
        {

            TiendaInfoRich.Text = "Nombre del Dueño: " + nombre + "\n" + "Numero Identificador: " + num + "\n " + "Horario de Atencion: " + horario + "\n " + "Categoria(s): "+ categoria;
        }

        private void TiendaAtrasButton_Click(object sender, EventArgs e)
        {
            TiendaInfoRich.Text = " ";
            TiendaInfoDueñoTextBox.Text = " ";
            TiendaInfoNumeroTextBox.Text = " ";
            TiendaInfoPanel.Visible = false;
            PanelPrincipal.Visible = true;
            PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;

        }

        private void CineInfoVerButton_Click(object sender, EventArgs e)
        {
            string nombredueño = CineInfoDueñoTextBox.Text;
            bool numcheck = false;
            int numero;
            numcheck = int.TryParse(CineInfoNumeroTextBox.Text, out numero);


            if (numcheck)
            {
                OnInfoCine(nombredueño, numero);

            }
            else
            {
                CineInfoExistTextBox.Text = "Ese cine no existe";
            }
        }
        private void OnInfoCine(string nombredueño, int numero)
        {
            if (InfoCine != null)
            {
                InfoCine(this, new CineEventArgs() { Nombre = nombredueño, Numero = numero });
            }
        }

        public void CineInfo(string nombre, int num, string horario, int sala)
        {

            CineInfoRich.Text = "Nombre del Dueño: " + nombre + "\n" + "Numero Identificador: " + num + "\n " + "Horario de Atencion: " + horario + "\n " + "Cantidad de salas: " + sala;
        }

        private void CineInfoAtrasButton_Click(object sender, EventArgs e)
        {
            CineInfoRich.Text = " ";
            CineInfoDueñoTextBox.Text = " ";
            CineInfoNumeroTextBox.Text = " ";
            CineInfoPanel.Visible = false;
            PanelPrincipal.Visible = true;
            PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void RevisarInfoCineButton_Click(object sender, EventArgs e)
        {
            RevisarLocalPanel.Visible = false;
            CineInfoPanel.Visible = true;
            CineInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void RevisarInfoRestButton_Click(object sender, EventArgs e)
        {
            RevisarLocalPanel.Visible = false;
            RestInfoPanel.Visible = true;
            RestInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }
        private void OnInfoRestaurante(string nombredueño, int numero)
        {
            if (InfoRestaurante != null)
            {
                InfoRestaurante(this, new RestauranteEventArgs() { Nombre = nombredueño, Numero = numero });
            }
        }

        public void RestauranteInfo(string nombre, int num, string horario, string mesas)
        {

            RestInfoRich.Text = "Nombre del Dueño: " + nombre + "\n" + "Numero Identificador: " + num + "\n " + "Horario de Atencion: " + horario + "\n " + "Contiene mesas exclusivas: " + mesas;
        }

        private void RestInfoAtrasButton_Click(object sender, EventArgs e)
        {
            RestInfoRich.Text = " ";
            RestInfoDueñoTextBox.Text = " ";
            RestInfoNumeroTextBox.Text = " ";
            RestInfoPanel.Visible = false;
            PanelPrincipal.Visible = true;
            PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void RestInfoVerButton_Click(object sender, EventArgs e)
        {
            string nombredueño = RestInfoDueñoTextBox.Text;
            bool numcheck = false;
            int numero;
            numcheck = int.TryParse(RestInfoNumeroTextBox.Text, out numero);


            if (numcheck)
            {
                OnInfoRestaurante(nombredueño, numero);

            }
            else
            {
                RestInfoExistTextrBox.Text = "Ese restaurante no existe";
            }
        }

        private void RecInfoVerButton_Click(object sender, EventArgs e)
        {
            string nombredueño = RecInfoDueñoTextBox.Text;
            bool numcheck = false;
            int numero;
            numcheck = int.TryParse(RecInfoNumeroTextBox.Text, out numero);


            if (numcheck)
            {
                OnInfoRecreacional(nombredueño, numero);

            }
            else
            {
                RecInfoExistTextBox.Text = "Ese centro recreacional no existe";
            }
        }
        private void OnInfoRecreacional(string nombredueño, int numero)
        {
            if (InfoRecreacional != null)
            {
                InfoRecreacional(this, new RecreacionalEventArgs() { Nombre = nombredueño, Numero = numero });
            }
        }

        private void RecInfoAtrasButton_Click(object sender, EventArgs e)
        {
            RecInfoRich.Text = " ";
            RecInfoDueñoTextBox.Text = " ";
            RecInfoNumeroTextBox.Text = " ";
            RecInfoPanel.Visible = false;
            PanelPrincipal.Visible = true;
            PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void RevisarInfoRecButtin_Click(object sender, EventArgs e)
        {
            RevisarLocalPanel.Visible = false;
            RecInfoPanel.Visible = true;
            RecInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }
        public void RecreacionalInfo(string nombre, int num, string horario)
        {
            RecInfoRich.Text = "Nombre del Dueño: " + nombre + "\n" + "Numero Identificador: " + num + "\n " + "Horario de Atencion: " + horario;
        }

        private void LocalesExistentesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }

}
