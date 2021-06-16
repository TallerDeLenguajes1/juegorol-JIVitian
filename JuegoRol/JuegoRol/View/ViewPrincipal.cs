using JuegoRol.Controller;
using System;
using System.Windows.Forms;

namespace JuegoRol.View
{
    public partial class ViewPrincipal : Form
    {
        private ControllerPersonaje controller;

        public ViewPrincipal()
        {
            InitializeComponent();
            controller = new ControllerPersonaje(this);
        }

        private void lbPersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.CambiarPersonaje();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            controller.AbrirVistaNuevoPersonaje();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            controller.BorrarPersonaje();
        }

        private void ViewPrincipal_VisibleChanged(object sender, EventArgs e)
        {
            controller.ActualizarLista();
        }
    }
}
