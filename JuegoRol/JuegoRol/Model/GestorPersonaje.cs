
using System;
using System.Collections.Generic;
using System.IO;

namespace JuegoRol.Model
{
    public class GestorPersonaje
    {
        private List<Personaje> personajes;

        /** <summary>
         * Este gestor es estatico para que esté en todas las instancias de la clase.
         * </summary>
         */
        private static GestorPersonaje gestor;

        public List<Personaje> Personajes { get => personajes; }

        /**
         * El constructor será privado para que no se pueda instanciar varias veces.
         */
        private GestorPersonaje()
        {
            personajes = new List<Personaje>();
        }

        /** <summary>
         * Instancia un objeto GestorPersonaje si éste no se instanció antes.
         * </summary>
         */
        public static GestorPersonaje Instanciar()
        {
            if (gestor == null)
                gestor = new GestorPersonaje();
            return gestor;
        }

        /**
         * <summary>
         * Establece las caractéristicas que tendrá un nuevo personaje.
         * Cada tipo tendrá sus stats base y podrán crecer cuando suban de nivel
         * </summary>
         * <param name="tipo">Indica el tipo de personaje.</param>
         */
        private Personaje SetCaracteristicas(TipoPersonaje tipo)
        {
            Personaje personaje = new Personaje();

            switch (tipo)
            {
                // La suma de todos los stats es 15
                case TipoPersonaje.Guerrero:
                    personaje.Velocidad = 4;
                    personaje.Destreza = 3;
                    personaje.Fuerza = 5;
                    personaje.Armadura = 3;
                    break;
                case TipoPersonaje.Paladin:
                    personaje.Velocidad = 2;
                    personaje.Destreza = 2;
                    personaje.Fuerza = 6;
                    personaje.Armadura = 5;
                    break;
                case TipoPersonaje.Arquero:
                    personaje.Velocidad = 4;
                    personaje.Destreza = 4;
                    personaje.Fuerza = 4;
                    personaje.Armadura = 3;
                    break;
                case TipoPersonaje.Ladron:
                    personaje.Velocidad = 6;
                    personaje.Destreza = 4;
                    personaje.Fuerza = 3;
                    personaje.Armadura = 2;
                    break;
            }

            return personaje;
        }

        /**
         * <summary>
         * Recibe los parametros de un personaje, lo instancia y lo agrega a la lista de personajes.
         * </summary>
         */
        public void NuevoPersonaje(string nombre, string apodo, TipoPersonaje tipo, DateTime bDay)
        {
            Personaje personaje = SetCaracteristicas(tipo);
            personaje.Tipo = tipo;
            personaje.Nombre = nombre;
            personaje.Apodo = apodo;
            personaje.FechaNacimiento = bDay;
            personaje.Edad = (DateTime.Now - bDay).Days / 365;

            // Añado el nuevo personaje a la lista
            personajes.Add(personaje);
        }

        public void BorrarPersonaje(int indice)
        {
            Personajes.RemoveAt(indice);
        }

        //public void CargarLista()
        //{
        //    FileStream archivo = new File.Open();
        //}
    }
}
