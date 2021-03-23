using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAPPLibrary.Torneo
{
    class Torneo
    {
        List<Equipo> equipos;
        int cantidadEquiposInscriptos;
        string premioGanador;
        string tipoDeporteTorneo;

        public Torneo(List<Equipo> equipos, int cantidadEquiposInscriptos, string premioGanador, string tipoDeporteTorneo)
        {
            this.Equipos = equipos;
            this.CantidadEquiposInscriptos = cantidadEquiposInscriptos;
            this.PremioGanador = premioGanador;
            this.TipoDeporteTorneo = tipoDeporteTorneo;
        }

        public int CantidadEquiposInscriptos { get => cantidadEquiposInscriptos; set => cantidadEquiposInscriptos = value; }
        public string PremioGanador { get => premioGanador; set => premioGanador = value; }
        public string TipoDeporteTorneo { get => tipoDeporteTorneo; set => tipoDeporteTorneo = value; }
        internal List<Equipo> Equipos { get => equipos; set => equipos = value; }
    }
}
