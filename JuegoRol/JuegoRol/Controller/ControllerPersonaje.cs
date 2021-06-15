﻿using JuegoRol.Model;
using JuegoRol.View;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            }
        }

        public void AbrirVistaNuevoPersonaje()
        {
            vista.Hide();

            ViewNuevoPersonaje vistaNP = new ViewNuevoPersonaje(vista);
            vistaNP.Show();
        } 

        public void BorrarPersonaje()
        {
            int indice = vista.LbxPersonajes.SelectedIndex;

            gp.BorrarPersonaje(indice);
            vista.LbxPersonajes.Items.RemoveAt(indice);
        }

        public void CambiarImagen()
        {
            int indice = vista.LbxPersonajes.SelectedIndex;
            string tipo = gp.Personajes.ElementAt(indice).Tipo.ToString();
            vista.ImgPersonaje.Image = Image.FromFile($@"..\Resources\{tipo}.png");
        }
    }
}
