using JuegoRol.Model;
using JuegoRol.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol.Controller
{
    public class ControllerBatalla
    {
        ViewBatalla vista;
        Personaje player, cpu;

        public ControllerBatalla(ViewBatalla vista, Personaje player, Personaje cpu)
        {
            this.vista = vista;
            this.player = player;
            this.cpu = cpu;
            CargarImagenes();
            CargarLabels();
        }

        public void Atacar()
        {
            SoundPlayer sonido = new SoundPlayer();
            sonido.SoundLocation = @"..\..\..\Resources\Impact.wav";
            sonido.Load();
            sonido.Play();
        }

        private void CargarImagenes()
        {
            string rutaPlayer = $@"..\..\..\Resources\{player.Tipo.ToString()}.png";
            string rutaCpu = $@"..\..\..\Resources\{cpu.Tipo.ToString()}.png";
            vista.ImgPlayer.Image = Image.FromFile(rutaPlayer);
            vista.ImgCpu.Image = Image.FromFile(rutaCpu);
        }

        private void CargarLabels()
        {
            vista.LbNombrePlayer.Text = player.ToString();
            vista.LbNivelPlayer.Text = "Nivel: " + player.Nivel.ToString();
            vista.LbNombreCpu.Text = cpu.ToString();
            vista.LbNivelCpu.Text = "Nivel: " + cpu.Nivel.ToString();
        }
    }
}
