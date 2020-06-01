using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboratorio08
{
    public class ControlTienda
    {
        //metodos de tienda, sus eventos
        List<Tienda> tiendas = new List<Tienda>();
        Form1 view;
        Form2 vie;
        public ControlTienda(Form1 view, Form2 vie)
        {
            TInitialize();
            this.view = view as Form1;
            this.vie = vie as Form2;
            this.view.TiendaCreate += OnTiendaCreate;
            this.view.InfoTienda += OnInfoTienda;
            this.vie.TiendaG += OnTiendaG;
        }
        public void TInitialize()
        {
            tiendas.Add(new Tienda("Tomas", 011, "10:00-18:00", "videojuegos"));
            tiendas.Add(new Tienda("Maria", 123, "7:00-22:00","ropa, juegos"));
        }
        public bool OnTiendaCreate(object sender, TiendaEventArgs e)
        {
            foreach (Tienda t in tiendas)
            {
                if (t.NombreDueño == e.Nombre && t.Codigo == e.Numero)
                {
                    return false;
                }
            }
            tiendas.Add(new Tienda(e.Nombre, e.Numero, e.Horarios, e.Categorias));
            return true;
        }
        
        public void OnInfoTienda(object sender, TiendaEventArgs e)
        {
            Tienda tienda = null;
            tienda = tiendas.Where(t =>
               t.NombreDueño.ToLower().Contains(e.Nombre.ToLower()) && t.Codigo == e.Numero).FirstOrDefault();
            if (tienda != null)
            {
                view.TiendaInfo(tienda.NombreDueño, tienda.Codigo, tienda.Horario, tienda.CategoriaTienda);
            }
            else
            {
                view.NoTienda();
            }
        }
        public List<Tienda> OnTiendaG(object sender, TiendaEventArgs e)
        {
            return tiendas;
        }



    }
}
