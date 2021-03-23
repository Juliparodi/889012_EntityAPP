using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAPPLibrary.Veterinaria
{
    public class Empleado
    {
        string nombre;
        string DNI;
        double sueldo;
        int edad;

        public Empleado(string nombre, string dNI, double sueldo, int edad)
        {
            this.Nombre = nombre;
            DNI1 = dNI;
            this.Sueldo = sueldo;
            this.Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
