using JuegoRol.Model;
using JuegoRol.View;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ActualizarLista();
        }

        public void ActualizarLista()
        {
            // Solo actualizará si la ventana está visible
            if (vista.Visible == true)
            {
                // Vacía la lista si tiene elementos
                if (vista.LbxPersonajes.Items.Count != 0)
                    vista.LbxPersonajes.Items.Clear();
                // Llena la lista con los valores de la lista del gestor personaje
                foreach (Personaje personaje in gp.Personajes)
                    vista.LbxPersonajes.Items.Add(personaje);
                vista.LbxPersonajes.SetSelected(0, true);
            }
        }

        public void AbrirVistaNuevoPersonaje()
        {
            vista.Hide();

            ViewNuevoPersonaje vistaNP = new ViewNuevoPersonaje(vista);
            vistaNP.ShowDialog();

            vista.Show();
        } 

        public void BorrarPersonaje()
        {
            int indice = vista.LbxPersonajes.SelectedIndex;

            gp.BorrarPersonaje(indice);
            vista.LbxPersonajes.Items.RemoveAt(indice);
        }

        public void CambiarPersonaje()
        {
            if (GetIndice() != -1) 
            {
                int indice = GetIndice();
                string tipo = gp.Personajes.ElementAt(indice).Tipo.ToString();
                string ruta = $@"..\..\..\Resources\{tipo}.png";
                vista.ImgPersonaje.Image = Image.FromFile(ruta);
                MostrarStats();
            }
            else
            {
                vista.ImgPersonaje.Image = null;
            }
        }

        private int GetIndice()
        {
            return vista.LbxPersonajes.SelectedIndex;
        }

        public void MostrarStats()
        {
            Personaje PJ = gp.Personajes.ElementAt(GetIndice());
            //Type datos = typeof(Personaje);
            //int y = 25;

            vista.LblNombre.Text = $"Nombre: {PJ.Nombre}";
            vista.LblApodo.Text = $"Apodo: {PJ.Apodo}";
            vista.LblEdad.Text = $"Edad: {PJ.Edad.ToString()} Años";
            vista.LblFecha.Text = $"Nacimiento: {PJ.FechaNacimiento.Date.ToString()}";
            vista.LblNivel.Text = $"Nivel: {PJ.Nivel.ToString()}";
            vista.LblFuerza.Text = $"Fuerza: {PJ.Fuerza.ToString()}";
            vista.LblVelocidad.Text = $"Velocidad: {PJ.Velocidad.ToString()}";
            vista.LblDestreza.Text = $"Destreza: {PJ.Destreza.ToString()}";
            vista.LblArmadura.Text = $"Armadura: {PJ.Armadura.ToString()}";
            vista.LblSalud.Text = $"Salud: {PJ.Salud.ToString()}";

            // Intenté crear dinamicamente los labels de los datos de los personajes pero no funcionó como esperaba
            //foreach (FieldInfo campo in datos.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            //{
            //    Label lbl = new Label();
            //    lbl.Size = new Size(20, 5);
            //    lbl.Location = new Point(460,y);
            //    lbl.Text = $"{campo.Name}: {campo.GetValue(personaje)}";
            //    vista.Controls.Add(lbl);
            //    y += 15;
            //}
        }
    }
}
