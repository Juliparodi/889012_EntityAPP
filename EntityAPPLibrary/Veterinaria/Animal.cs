using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAPPLibrary.Veterinaria
{
    public class Animal
    {
        string tipoAnimal;
        int edad;

        public Animal(string tipoAnimal, int edad)
        {
            this.TipoAnimal = tipoAnimal;
            this.Edad = edad;
        }

        public string TipoAnimal { get => tipoAnimal; set => tipoAnimal = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
