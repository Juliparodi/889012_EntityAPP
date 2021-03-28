using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAPPLibrary.Veterinaria;
using EntityAPPLibrary.Restaurant;

namespace EntityAPPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //VETERINARIA
            Veterinaria veterinaria = new Veterinaria();
            List<Empleado> empleados = new List<Empleado>();

            Empleado empleado = new Empleado("juli parodi", "40856523", 3000, 23);
            Empleado empleado2 = new Empleado("pepe", "40856524", 4000, 40);

            empleados.Add(empleado);
            empleados.Add(empleado2);

            List<Animal> animales = new List<Animal>();
            Animal animal = new Animal("gato", 8);
            Animal animal1 = new Animal("perro", 10);

            animales.Add(animal);
            animales.Add(animal1);

            veterinaria.CantidadSucursales = 100;
            veterinaria.Domicilio = "av mitre 3000";
            veterinaria.Empleados = empleados;

            Console.WriteLine("cantidad sucursales {0}: ", veterinaria.CantidadSucursales);

            //RESTAURANT
            Restaurant restaurant = new Restaurant();
            List<Sucursal> sucursales = new List<Sucursal>();
            Sucursal sucursal = new Sucursal("av mitre", "10", 09, 18);
            Sucursal sucursal1 = new Sucursal("av mitre", "8", 18, 18);
            sucursales.Add(sucursal);
            sucursales.Add(sucursal1);

            restaurant.CantidadSucursales = 10;
            restaurant.Sucursales = sucursales;
            restaurant.Empleados = empleados;

            Console.WriteLine("cantidad sucursales: {0}: ", restaurant.CantidadSucursales);

            //METODO QUE AFECTA O CAMBIA UN ESTADO
            Almacen.agregarSucursal(sucursal);

            //METODO Q SE COMPORTA DISTINTO DEPENDIENDO EL ESTADO
            Carta carta = new Carta();
            string contenido = "Hola queria solicitar una entrevista, muchas gracias";
            string mailCreador = "julianparodi19@gmail.com";
            string mailRecipiente = "consultoria@gmail.com";

            carta = carta.creacionCarta(mailRecipiente, mailCreador, contenido);
            Console.WriteLine("La carta se ha enviado exitosamente hacia {0}", carta.MailRecipiente);

        }
    }
}
