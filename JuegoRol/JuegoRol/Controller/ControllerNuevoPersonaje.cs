using JuegoRol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol.Controller
{
    class ControllerNuevoPersonaje
    {
        private ViewNuevoPersonaje vista;
        private GestorPersonaje gp;

        public ControllerNuevoPersonaje(ViewNuevoPersonaje vista)
        {
            this.vista = vista;
            gp = GestorPersonaje.Instanciar();
            // Lleno la ComboBox con todos los elementos del enum TipoPersonaje
            vista.CbType.DataSource = Enum.GetValues(typeof(TipoPersonaje));
        }

        public void Crear()
        {
            string nombre = vista.TxtName.Text;
            string apodo = vista.TxtNick.Text;
            TipoPersonaje tipo = (TipoPersonaje)vista.CbType.SelectedItem;
            DateTime fechaNacimiento = vista.DtDate.Value;

            gp.NuevoPersonaje(nombre, apodo, tipo, fechaNacimiento);

            Cerrar();
        }

        public void Cerrar()
        {
            vista.Dispose();
            vista.Padre.Show();
        }
    }
}
