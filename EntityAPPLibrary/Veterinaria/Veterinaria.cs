using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAPPLibrary.Veterinaria
{
    public class Veterinaria
    {
        string domicilio;
        List<Empleado> empleados;
        int cantidadSucursales;
        List<Animal> animales;
        string horarioAtencion;

        public Veterinaria()
        {

        }
      
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public List<Empleado> Empleados { get => empleados; set => empleados = value; }
        public int CantidadSucursales { get => cantidadSucursales; set => cantidadSucursales = value; }
        public string HorarioAtencion { get => horarioAtencion; set => horarioAtencion = value; }
        internal List<Animal> Animales { get => animales; set => animales = value; }
    }
}
