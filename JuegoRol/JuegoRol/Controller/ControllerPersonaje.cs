using JuegoRol.Model;
using JuegoRol.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol.Controller
{
    public class ControllerPersonaje
    {
        private ViewPrincipal vista;
        private GestorPersonaje gp;

        public ControllerPersonaje(ViewPrincipal vista)
        {
            this.vista = vista;
            this.gp = GestorPersonaje.Instanciar();
            vista.LbxPersonajes.DataSource = gp.Personajes;
        }

        public void CargarLista()
        {
            vista.LbxPersonajes.DataSource = gp.Personajes;
        }

        public void AgregarPersonaje()
        {
            vista.Hide();

            ViewNuevoPersonaje vistaNP = new ViewNuevoPersonaje(vista);
            vistaNP.Show();
        }
    }
}
