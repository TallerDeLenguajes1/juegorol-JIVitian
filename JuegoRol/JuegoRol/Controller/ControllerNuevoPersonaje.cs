using JuegoRol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (Verificar(nombre) && Verificar(apodo))
            {
                gp.NuevoPersonaje(nombre, apodo, tipo, fechaNacimiento);
                Cerrar();
            }
            else MessageBox.Show("El personaje debe tener un nombre y un apodo", "Error");
        }

        public void CrearAleatorio()
        {
            TestPersonaje.CrearPersonaje();
            Cerrar();
        }

        private bool Verificar(string texto)
        {
            string expresionValida = @"\A[a-zA-Z]+\z";
            Regex reg = new Regex(expresionValida);

            return reg.IsMatch(texto);
        }

        public void Cerrar()
        {
            vista.Dispose();
        }
    }
}
