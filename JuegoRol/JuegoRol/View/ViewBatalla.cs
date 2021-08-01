using JuegoRol.Controller;
using JuegoRol.Model;
using System;
using System.Windows.Forms;

namespace JuegoRol.View
{
    public partial class ViewBatalla : Form
    {
        ControllerBatalla controller;
        public ViewBatalla(Personaje player, Personaje cpu)
        {
            InitializeComponent();
            this.controller = new ControllerBatalla(this, player, cpu);
        }

        private void btnAtacarPlayer_Click(object sender, EventArgs e)
        {
            controller.Luchar();
        }
    }
}
