using JuegoRol.Model;
using JuegoRol.View;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Threading;
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
            ConsumirAPI();
        }

        private void CargarImagenes()
        {
            string rutaPlayer = $@"..\..\..\Resources\{player.Tipo}.png";
            string rutaCpu = $@"..\..\..\Resources\{cpu.Tipo}.png";
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

        public void Luchar()
        {
            int ronda = 0;
            // La batalla durará 3 rondas o hasta que alguno de los personajes se quede sin vida
            while (player.Salud > 0 && cpu.Salud > 0 && ronda < 3)
            {
                // El personaje que tiene mas velocidad ataca primero
                if (player.Velocidad > cpu.Velocidad)
                    IniciarRonda(player, cpu, vista.VidaPlayer1, vista.VidaCpu);
                else
                    IniciarRonda(cpu, player, vista.VidaCpu, vista.VidaPlayer1);
                ronda++;
            }

            SeleccionarGanador();

            vista.Dispose();
        }

        private void IniciarRonda(Personaje pj1, Personaje pj2, ProgressBar barraPj1, ProgressBar barraPj2)
        {
            Atacar(pj1, pj2, barraPj2);
            // Si el personaje atacado resiste, contrataca
            if (pj2.Salud > 0) Atacar(pj2, pj1, barraPj1);
        }

        private void Atacar(Personaje atacante, Personaje atacado, ProgressBar barra)
        {
            CalcularDanio(atacante, atacado);
            EmitirSonido();
            BajarVida(barra, atacado.Salud);
        }

        private void CalcularDanio(Personaje pj, Personaje pj2)
        {
            Random random = new Random();
            int poder, efectividad, valor, defensa, danio;
            const int MDP = 500000;

            poder = pj.Destreza * pj.Fuerza * pj.Nivel;
            efectividad = random.Next(1, 101);
            valor = poder * efectividad;
            defensa = pj2.Armadura * pj2.Velocidad;
            danio = (valor * efectividad - defensa) * 100 / (MDP);

            pj2.Salud -= danio;
            if (pj2.Salud < 0) pj2.Salud = 0;
        }

        private void BajarVida(ProgressBar barra, int salud)
        {
            int valorInicial = barra.Value;
            for (int i = valorInicial; i > salud; i--)
            {
                barra.Value = i;
                Thread.Sleep(25);
            }
        }

        private void SeleccionarGanador()
        {
            if (cpu.Salud == player.Salud)
                MessageBox.Show("Empate!");
            else
                MessageBox.Show($"El ganador es: {(player.Salud > cpu.Salud ? player : cpu)}");
        }

        /**
         * <summary>Consume una API que proporciona imagenes aleatorias para el fondo de la vista de batallas</summary>
         */
        private void ConsumirAPI()
        {
            var url = $"https://source.unsplash.com/random/?scenery,medieval";
            var request = WebRequest.Create(url);

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            vista.BackgroundImage = Bitmap.FromStream(strReader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
