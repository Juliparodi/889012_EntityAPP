using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAPPLibrary.Torneo
{
    class Equipo
    {
        string nombreEquipo;
        int cantidadJugadores;
        string ciudad;

        public Equipo(string nombreEquipo, int cantidadJugadores, string ciudad)
        {
            this.NombreEquipo = nombreEquipo;
            this.CantidadJugadores = cantidadJugadores;
            this.Ciudad = ciudad;
        }

        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public int CantidadJugadores { get => cantidadJugadores; set => cantidadJugadores = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
