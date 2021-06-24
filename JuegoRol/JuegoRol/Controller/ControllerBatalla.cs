using JuegoRol.Model;
using JuegoRol.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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
            ActualizarVida();
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

        private void ActualizarVida()
        {
            vista.VidaPlayer1.Value = player.Salud;
            vista.VidaCpu.Value = cpu.Salud;
        }

        private void EmitirSonido()
        {
            SoundPlayer sonido = new SoundPlayer();
            sonido.SoundLocation = @"..\..\..\Resources\Impact.wav";
            sonido.Load();
            sonido.Play();
        }

        public void Atacar()
        {
            int ronda = 0;
            while (player.Salud > 0 && cpu.Salud > 0 && ronda < 3)
            {
                if (player.Velocidad > cpu.Velocidad)
                {
                    CalcularDanio(player, cpu);
                    BajarVida(vista.VidaCpu, cpu.Salud);
                    EmitirSonido();

                    if (cpu.Salud > 0)
                    {
                        CalcularDanio(cpu, player);
                        BajarVida(vista.VidaPlayer1, player.Salud);
                        EmitirSonido();
                    }
                }
                else
                {
                    CalcularDanio(cpu, player);
                    BajarVida(vista.VidaPlayer1, player.Salud);
                    EmitirSonido();

                    if (player.Salud > 0)
                    {
                        CalcularDanio(player, cpu);
                        BajarVida(vista.VidaCpu, cpu.Salud);
                        EmitirSonido();
                    }
                }
                ronda++;
            }

            if (cpu.Salud > player.Salud)
            {
                MessageBox.Show("Gana CPU");
            }
            else
            {
                MessageBox.Show("Gana Player");
            }
            vista.Dispose();
        }

        private void CalcularDanio(Personaje pj, Personaje pj2)
        {
            Random random = new Random();
            int poder, efectividad, valor, defensa, danio;
            const int MDP = 50000;

            poder = pj.Destreza * pj.Fuerza * pj.Nivel;
            efectividad = random.Next(1, 101);
            valor = poder * efectividad;
            defensa = pj2.Armadura * pj2.Velocidad;
            danio = (valor * efectividad - defensa) * 50 / (MDP * 2);

            pj2.Salud -= danio;
            if (pj2.Salud < 0) pj2.Salud = 0;
        }

        private void BajarVida(ProgressBar barra, int salud)
        {
            int valorInicial = barra.Value;
            for (int i = valorInicial; i > salud; i--)
            {
                barra.Value = i;
                Thread.Sleep(10);
            }
        }
    }
}
