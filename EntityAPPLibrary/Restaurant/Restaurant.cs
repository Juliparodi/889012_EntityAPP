using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAPPLibrary.Veterinaria;

namespace EntityAPPLibrary.Restaurant
{
    public class Restaurant
    {
        List<Sucursal> sucursales;
        int cantidadSucursales;
        List<Empleado> empleados;

        public Restaurant() { }
        public Restaurant(List<Sucursal> sucursales, int cantidadSucursales, List<Empleado> empleados)
        {
            this.Sucursales = sucursales;
            this.CantidadSucursales = cantidadSucursales;
            this.Empleados = empleados;
        }

        public List<Sucursal> Sucursales { get => sucursales; set => sucursales = value; }
        public int CantidadSucursales { get => cantidadSucursales; set => cantidadSucursales = value; }
        public List<Empleado> Empleados { get => empleados; set => empleados = value; }
    }
}
