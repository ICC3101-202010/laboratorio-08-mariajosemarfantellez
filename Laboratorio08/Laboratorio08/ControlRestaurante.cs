using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Laboratorio08
{
    class ControlRestaurante
    {
        //metodos de restaurante, sus eventos
        List<Restaurante> restaurantes = new List<Restaurante>();
        Form1 view;
        Form2 vie;
        public ControlRestaurante(Form1 view, Form2 vie)
        {
            RInitialize();
            this.view = view as Form1;
            this.vie = vie as Form2;
            this.view.RestauranteCreate += OnRestauranteCreate;
            this.view.InfoRestaurante += OnInfoRestaurante;
            this.vie.RestG += OnRestG;

        }
        public void RInitialize()
        {
            restaurantes.Add(new Restaurante("Jose", 345, "9:00-18:00","si"));
            restaurantes.Add(new Restaurante("Pepa", 987, "8:00-22:00", "no"));
        }
        public bool OnRestauranteCreate(object sender, RestauranteEventArgs e)
        {
            foreach (Restaurante t in restaurantes)
            {
                if (t.NombreDueño == e.Nombre && t.Codigo == e.Numero)
                {
                    return false;
                }
            }
            restaurantes.Add(new Restaurante(e.Nombre, e.Numero, e.Horarios, e.MesasExclusivas));
            return true;
        }
        public void OnInfoRestaurante(object sender, RestauranteEventArgs e)
        {

            Restaurante rest = null;
            rest = restaurantes.Where(t =>
               t.NombreDueño.ToLower().Contains(e.Nombre.ToLower()) && t.Codigo == e.Numero).FirstOrDefault();
            if (rest != null)
            {
                view.RestauranteInfo(rest.NombreDueño, rest.Codigo, rest.Horario, rest.Mesas);
            }
            else
            {
                view.NoRest();
            }
        }
        public List<Restaurante> OnRestG(object sender, RestauranteEventArgs e)
        {
            return restaurantes;
        }
    }

}
