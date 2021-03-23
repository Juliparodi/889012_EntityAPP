using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAPPLibrary.Restaurant
{
    public class Sucursal
    {
        string domicilio;
        string cantidadEmpleados;
        int horarioApertura;
        int horarioCierre;

        public Sucursal(string domicilio, string cantidadEmpleados, int horarioApertura, int horarioCierre)
        {
            this.Domicilio = domicilio;
            this.CantidadEmpleados = cantidadEmpleados;
            this.HorarioApertura = horarioApertura;
            this.HorarioCierre = horarioCierre;
        }

        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string CantidadEmpleados { get => cantidadEmpleados; set => cantidadEmpleados = value; }
        public int HorarioApertura { get => horarioApertura; set => horarioApertura = value; }
        public int HorarioCierre { get => horarioCierre; set => horarioCierre = value; }
    }
}
