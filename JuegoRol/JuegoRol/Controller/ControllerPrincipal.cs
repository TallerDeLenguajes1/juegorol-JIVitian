using JuegoRol.Model;
using JuegoRol.View;
using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace JuegoRol.Controller
{
    public class ControllerPrincipal
    {
        private ViewPrincipal vista;
        private GestorPersonaje gp;
        private bool yaPelearon;

        public ControllerPrincipal(ViewPrincipal vista)
        {
            this.vista = vista;
            gp = GestorPersonaje.Instanciar();
            yaPelearon = false;
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
                vista.LbxPersonajes.SelectedItem = 0;
                SeleccionarPrimero();
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

            if (indice != -1)
            {
                gp.BorrarPersonaje(indice);
                vista.LbxPersonajes.Items.RemoveAt(indice);
                SeleccionarPrimero();
            }
        }

        private void SeleccionarPrimero()
        {
            if (gp.Personajes.Count > 0)
                vista.LbxPersonajes.SetSelected(0, true);
            else
                DefaultStats();
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
            vista.LblEdad.Text = $"Edad: {PJ.Edad} Años";
            vista.LblFecha.Text = $"Nacimiento: {PJ.FechaNacimiento.Date.ToString("dd/MM/yyyy")}";
            vista.LblNivel.Text = $"Nivel: {PJ.Nivel}";
            vista.LblFuerza.Text = $"Fuerza: {PJ.Fuerza}";
            vista.LblVelocidad.Text = $"Velocidad: {PJ.Velocidad}";
            vista.LblDestreza.Text = $"Destreza: {PJ.Destreza}";
            vista.LblArmadura.Text = $"Armadura: {PJ.Armadura}";
            vista.LblSalud.Text = $"Salud: {PJ.Salud}";
        }

        private void DefaultStats()
        {
            vista.LblNombre.Text = "Nombre: -";
            vista.LblApodo.Text = "Apodo: -";
            vista.LblEdad.Text = "Edad: -";
            vista.LblFecha.Text = "Nacimiento: -";
            vista.LblNivel.Text = "Nivel: -";
            vista.LblFuerza.Text = "Fuerza: -";
            vista.LblVelocidad.Text = "Velocidad: -";
            vista.LblDestreza.Text = "Destreza: -";
            vista.LblArmadura.Text = "Armadura: -";
            vista.LblSalud.Text = "Salud: -";
        }

        public void AbrirVistaBatalla()
        {
            yaPelearon = true;
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

                    if(player.Salud < cpu.Salud)
                        BatallaTerminada(cpu, player);
                    if (player.Salud > cpu.Salud)
                        BatallaTerminada(player, cpu);

                    VerificarCampeon();
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
            // Si los dos personajes son iguales, se elige otro.
            while (cpu == GetPersonaje()) cpu = PersonajeAleatorio();

            return cpu;
        }

        private Personaje PersonajeAleatorio()
        {
            Random random = new Random();
            return GetPersonaje(random.Next(0, vista.LbxPersonajes.Items.Count));
        }

        public void VerificarCampeon()
        {
            if (yaPelearon && gp.Personajes.Count == 1)
            {
                SoundPlayer sonido = new SoundPlayer();
                sonido.SoundLocation = @"..\..\..\Resources\Win.wav";
                sonido.Load();
                sonido.Play();
                MessageBox.Show($"El Ganador del torneo es {gp.Personajes.First()}", "FELICIDADES");
                GuardarGanador();
            }
        }

        private void BatallaTerminada(Personaje ganador, Personaje perdedor)
        {
            gp.Personajes.Remove(perdedor);
            vista.LbxPersonajes.SelectedItem = gp.Personajes.IndexOf(ganador);
            vista.LbxPersonajes.SetSelected(gp.Personajes.IndexOf(ganador), true);
            SubirNivel(ganador);
        }

        private void SubirNivel(Personaje pj)
        {
            pj.Nivel++;
            pj.Salud = (pj.Salud < 90) ? pj.Salud + 10 : 100;
            pj.Fuerza++;
            pj.Velocidad++;
            pj.Destreza = (pj.Destreza <= 4) ? pj.Destreza + 1 : 5;
        }

        private void GuardarGanador()
        {
            List<Personaje> ganadores = ObtenerRanking();
            ganadores.Add(gp.Personajes.First());

            string DatosJson = JsonSerializer.Serialize(ganadores);

            using (FileStream archivo = new FileStream("Ranking.JSON", FileMode.OpenOrCreate))
            {
                StreamWriter strWrite = new StreamWriter(archivo);
                strWrite.WriteLine(DatosJson);
                strWrite.Close();
                strWrite.Dispose();
            }
        }

        public List<Personaje> ObtenerRanking()
        {
            string path = "Ranking.JSON";

            if (File.Exists(path))
            {
                List<Personaje> ganadores = new List<Personaje>();

                using (FileStream archivo = new FileStream(path, FileMode.Open))
                {
                    StreamReader strReader = new StreamReader(archivo);
                    string json = strReader.ReadToEnd();
                    strReader.Close();
                    strReader.Dispose();
                    ganadores = JsonSerializer.Deserialize<List<Personaje>>(json);
                }

                return ganadores;
            } else
                return new List<Personaje>();
        }

        public void VerRanking()
        {
            List<Personaje> ganadores = ObtenerRanking();
            string ranking = "";

            for (int i = 0; i < ganadores.Count; i++)
                ranking += $"{i + 1}. {ganadores.ElementAt(i)}\n";

            MessageBox.Show(ranking != "" ? ranking : "Todavía no se registraron ganadores!", "Ranking");
        }
    }
}
