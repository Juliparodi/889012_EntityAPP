using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAPPLibrary.Restaurant;

namespace EntityAPPLibrary.Almacen
{
    public class Almacen
    {
        List<Sucursal> sucursales;
        int cantidadSucursales;
        string domicilio;

        public Almacen(List<Sucursal> sucursales, int cantidadSucursales, string domicilio)
        {
            this.Sucursales = sucursales;
            this.CantidadSucursales = cantidadSucursales;
            this.Domicilio = domicilio;
        }

        public List<Sucursal> Sucursales { get => sucursales; set => sucursales = value; }
        public int CantidadSucursales { get => cantidadSucursales; set => cantidadSucursales = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
    }
}
