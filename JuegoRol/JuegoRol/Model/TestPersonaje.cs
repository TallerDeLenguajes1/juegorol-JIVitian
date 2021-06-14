using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol.Model
{
    public static class TestPersonaje
    {
        private static Random aleatorio = new Random();

        private static GestorPersonaje gestor = GestorPersonaje.Instanciar();

        public static void CrearPersonaje()
        {
            gestor.NuevoPersonaje(generarNombre(), generarApodo(), generarTipo(), generarFechaNacimiento());
        }

        //Obtención de los Datos
        public static TipoPersonaje generarTipo()
        {
            int num = aleatorio.Next(5);
            TipoPersonaje tipo;

            switch (num)
            {
                case 0:
                    tipo = TipoPersonaje.Guerrero;
                    break;
                case 1:
                    tipo = TipoPersonaje.Paladin;
                    break;
                case 2:
                    tipo = TipoPersonaje.Arquero;
                    break;
                default:
                    tipo = TipoPersonaje.Ladron;
                    break;
            }
            return tipo;
        }

        public static string generarNombre()
        {
            string[] nombres = { "Carlos", "Maria", "Pedro", "Juan", "Lucia" };
            string[] apellidos = { "Perez", "Gonzales", "Ramirez", "Albornoz", "Torres" };

            return nombres[aleatorio.Next(nombres.Length - 1)] + " " + apellidos[aleatorio.Next(apellidos.Length - 1)];
        }

        public static string generarApodo()
        {
            string[] apodos = { "Pepe", "Gordo", "Alto", "Flaco", "Cangurin" };

            return apodos[aleatorio.Next(apodos.Length - 1)];
        }

        public static DateTime generarFechaNacimiento()
        {
            return new DateTime(aleatorio.Next(1721, 2000), aleatorio.Next(1, 12), aleatorio.Next(1, 28));
        }

        //public static void MostrarLista()
        //{
        //    gestor.MostrarPersonajes();
        //}
    }
}
