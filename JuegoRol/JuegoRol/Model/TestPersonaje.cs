using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol.Model
{
    public class Nombre 
    {
        [JsonPropertyName("codigo")]
        public List<string> codigo { get; set; } 
    }

    public class TestPersonaje
    {
        private static Random aleatorio = new Random();
        private static Nombre Nombres = new Nombre();

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

        public static void ConsumirAPINombre()
        {
            var url = $"http://ensaimeitor.apsl.net/personas/1/?format=json&num=1";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                Nombres = JsonSerializer.Deserialize<Nombre>(responseBody);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            

        }

        public static string generarNombre()
        {
            ConsumirAPINombre();
            //string[] nombres = { "Carlos", "Maria", "Pedro", "Juan", "Lucia" };
            //string[] apellidos = { "Perez", "Gonzales", "Ramirez", "Albornoz", "Torres" };


            return Nombres.codigo.First();
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
