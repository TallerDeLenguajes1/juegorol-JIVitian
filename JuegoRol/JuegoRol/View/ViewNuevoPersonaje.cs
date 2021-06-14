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
        // Guardo la ventana de la que se invoco esta para poder abrirla de nuevo luego
        private Form padre;
        private ControllerNuevoPersonaje controller;

        public Form Padre { get => padre;}

        public ViewNuevoPersonaje(Form padre)
        {
            this.padre = padre;
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
    }
}
