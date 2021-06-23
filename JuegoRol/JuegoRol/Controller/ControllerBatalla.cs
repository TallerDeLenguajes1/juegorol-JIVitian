using JuegoRol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol.Controller
{
    public class ControllerBatalla
    {
        Form vista;
        Personaje player, cpu;

        public ControllerBatalla(Form vista, Personaje player, Personaje cpu)
        {
            this.vista = vista;
            this.player = player;
            this.cpu = cpu;
        }

        
    }
}
