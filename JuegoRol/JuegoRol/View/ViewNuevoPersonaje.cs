using JuegoRol.Controller;
using System;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class ViewNuevoPersonaje : Form
    {
        private ControllerNuevoPersonaje controller;

        public ViewNuevoPersonaje()
        {
            InitializeComponent();
            this.controller = new ControllerNuevoPersonaje(this);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            controller.Crear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controller.Cerrar();
        }

        private void Aleatorio_Click(object sender, EventArgs e)
        {
            controller.CrearAleatorio();
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            // Por alguna razón me dice que el controlador es null cuando se abre la ventana
            if (controller != null) controller.ActualizarImagen();
        }
    }
}
