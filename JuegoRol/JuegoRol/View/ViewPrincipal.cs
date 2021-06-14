using JuegoRol.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //imgPersonaje.Image = Image.FromFile("../Resources/Paladin.png");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            controller.AgregarPersonaje();
        }
    }
}
