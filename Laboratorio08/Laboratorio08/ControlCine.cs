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
    class ControlCine
    {
        //metodos de cine, sus eventos
        List<Cine> cines = new List<Cine>();
        Form1 view;
        Form2 vie;
        public ControlCine(Form1 view, Form2 vie)
        {
            Initialize();
            this.view = view as Form1;
            this.vie = vie as Form2;
            this.view.CineCreate += OnCineCreate;
            this.view.InfoCine += OnInfoCine;
            this.vie.CineG += OnCineG;
        }
        public void Initialize()
        {
            cines.Add(new Cine("Lucia", 567, "9:00-18:00", 5));
            cines.Add(new Cine("Ignacio",850, "8:00-22:00", 10));
        }
        public bool OnCineCreate(object sender, CineEventArgs e)
        {
            foreach (Cine t in cines)
            {
                if (t.NombreDueño == e.Nombre && t.Codigo == e.Numero)
                {
                    return false;
                }
            }
            cines.Add(new Cine(e.Nombre, e.Numero, e.Horarios, e.Salas));
            return true;
        }
        public void OnInfoCine(object sender, CineEventArgs e)
        {

            Cine cine = null;
            cine = cines.Where(t =>
               t.NombreDueño.ToLower().Contains(e.Nombre.ToLower()) && t.Codigo == e.Numero).FirstOrDefault();

            if (cine != null)
            {
                view.CineInfo(cine.NombreDueño, cine.Codigo, cine.Horario, cine.NumeroSalas);
            }
            else
            {
                view.NoCine();
            }

        }
        public List<Cine> OnCineG(object sender, CineEventArgs e)
        {
            return cines;
        }
    }
}
