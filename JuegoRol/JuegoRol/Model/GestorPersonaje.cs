
using System;
using System.Collections.Generic;

namespace JuegoRol.Model
{
    public class GestorPersonaje
    {
        private LinkedList<Personaje> personajes;
        /**
         * Este gestor es estatico para que esté en todas las instancias de la clase.
         */
        private static GestorPersonaje gestor;

        /**
         * El constructor será privado para que no se pueda instanciar varias veces.
         */
        private GestorPersonaje()
        {
            personajes = new LinkedList<Personaje>();
        }

        /**
         * Solo se podrá instanciar un gestor de personajes
         */
        public static GestorPersonaje Instanciar()
        {
            if (gestor == null)
                gestor = new GestorPersonaje();
            return gestor;
        }

        /**
         * Cada tipo tendrá sus stats base y podrán crecer cuando suban de nivel
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
         * Recibe los parametros de un personaje, lo instancia y lo agrega a la lista de personajes.
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
            personajes.AddLast(new LinkedListNode<Personaje>(personaje));
        }

        public void MostrarPersonajes()
        {
            LinkedListNode<Personaje> p = personajes.First;
            while (p != null)
            {
                Console.WriteLine(p.Value);
                p = p.Next;
            }
        }
        /*
        public Personaje getPersonaje()
        {
            return new Personaje();
        }

        public void BorrarPersonaje()
        {

        }

        public void LeerPersonajes()
        {

        }

        public void ActualizarPersonaje()
        {

        }
        */
    }
}
