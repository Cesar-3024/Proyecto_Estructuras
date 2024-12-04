using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estructuras.Pantallas
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Puntuacion { get; set; }

        public Jugador(string nombre, int puntuacion)
        {
            Nombre = nombre;
            Puntuacion = puntuacion;
        }
    }

    public class NodoJugador
    {
        public Jugador Valor;
        public NodoJugador Siguiente;
        public NodoJugador Anterior;
        private Jugador jugador;

        public NodoJugador(Jugador jugador)
        {
            this.jugador = jugador;
        }
    }

}