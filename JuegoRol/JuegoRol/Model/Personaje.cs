using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol.Model
{
     public enum Clase
    {
        Guerrero,
        Paladin,
        Arquero,
        Ladron
    }

    public class Personaje
    {
        // Datos
        private Clase tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNacimiento;
        private int edad;
        private int salud;

        // Stats
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        private Clase Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }

        public Personaje(string nombre, string apodo, DateTime fechaNacimiento, Clase tipo)
        {
            this.salud = 100;
            this.nivel = 1;
            this.nombre = nombre;
            this.apodo = apodo;
            this.tipo = tipo;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = DateTime.Now.Year - fechaNacimiento.Year;
            setCaracteristicas(tipo);
        }

        private void setCaracteristicas(Clase tipo)
        {
            switch (tipo)
            {
                // La suma de todos los stats es 20
                case Clase.Guerrero:
                    this.velocidad = 5;
                    this.destreza = 7;
                    this.fuerza = 7;
                    this.armadura = 4;
                    break;
                case Clase.Paladin:
                    this.velocidad = 4;
                    this.destreza = 4;
                    this.fuerza = 6;
                    this.armadura = 6;
                    break;
                case Clase.Arquero:
                    this.velocidad = 6;
                    this.destreza = 7;
                    this.fuerza = 3;
                    this.armadura = 4;
                    break;
                case Clase.Ladron:
                    this.velocidad = 8;
                    this.destreza = 7;
                    this.fuerza = 3;
                    this.armadura = 2;
                    break;
            }
        }

        public void getDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}\n" +
                $"Apodo: {Apodo}" +
                $"\nFecha de Nacimiento: {FechaNacimiento}\n" +
                $"Edad: {Edad}" +
                $"Salud: {Salud}\n");
        }

        public void getCaracteristicas()
        {

        }
    }
}