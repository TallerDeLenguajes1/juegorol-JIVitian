using JuegoRol.Controller;
using System;
using System.Windows.Forms;

namespace JuegoRol.View
{
    public partial class ViewPrincipal : Form
    {
        private ControllerPrincipal controller;

        public ViewPrincipal()
        {
            InitializeComponent();
            controller = new ControllerPrincipal(this);
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

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            controller.AbrirVistaBatalla();
        }

        private void Ranking_Click(object sender, EventArgs e)
        {
            controller.VerRanking();
        }
    }
}
