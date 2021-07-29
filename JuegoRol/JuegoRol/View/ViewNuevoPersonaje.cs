using JuegoRol.Controller;
using JuegoRol.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
