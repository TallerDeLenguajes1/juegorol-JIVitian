using JuegoRol.Model;
using JuegoRol.View;
using System;
using System.Drawing;
using System.Linq;
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

            ViewNuevoPersonaje vistaNP = new ViewNuevoPersonaje();
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
            int indice = GetIndice();
            if (indice != -1)
            {
                string tipo = GetPersonaje(indice).Tipo.ToString();
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

        private Personaje GetPersonaje()
        {
            return gp.Personajes.ElementAt(GetIndice());
        }

        private Personaje GetPersonaje(int index)
        {
            return gp.Personajes.ElementAt(index);
        }

        private void MostrarStats()
        {
            Personaje PJ = GetPersonaje();

            vista.LblNombre.Text = $"Nombre: {PJ.Nombre}";
            vista.LblApodo.Text = $"Apodo: {PJ.Apodo}";
            vista.LblEdad.Text = $"Edad: {PJ.Edad.ToString()} Años";
            vista.LblFecha.Text = $"Nacimiento: {PJ.FechaNacimiento.Date.ToString("dd/MM/yyyy")}";
            vista.LblNivel.Text = $"Nivel: {PJ.Nivel.ToString()}";
            vista.LblFuerza.Text = $"Fuerza: {PJ.Fuerza.ToString()}";
            vista.LblVelocidad.Text = $"Velocidad: {PJ.Velocidad.ToString()}";
            vista.LblDestreza.Text = $"Destreza: {PJ.Destreza.ToString()}";
            vista.LblArmadura.Text = $"Armadura: {PJ.Armadura.ToString()}";
            vista.LblSalud.Text = $"Salud: {PJ.Salud.ToString()}";
        }

        public void AbrirVistaBatalla()
        {
            if (vista.LbxPersonajes.Items.Count > 1)
            {
                if(GetIndice() != -1)
                {
                    Personaje player, cpu;

                    Random random = new Random();
                    player = GetPersonaje();
                    cpu = SeleccionarCPU();

                    vista.Hide();

                    ViewBatalla vistaB = new ViewBatalla(player, cpu);
                    vistaB.ShowDialog();

                    vista.Show();
                }
            } else
            {
                MessageBox.Show("Debe haber por lo menos 2 personajes para iniciar una batalla.", "Error");
            }
        }

        private Personaje SeleccionarCPU()
        {
            Personaje cpu = PersonajeAleatorio();
            while (cpu == GetPersonaje())
                cpu = PersonajeAleatorio();

            return cpu;
        }

        private Personaje PersonajeAleatorio()
        {
            Random random = new Random();
            return GetPersonaje(random.Next(0, vista.LbxPersonajes.Items.Count));
        }
    }
}
