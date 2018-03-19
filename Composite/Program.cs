
using Composite.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Paquete paquete = new Paquete { Nombre = "Paquete Vacaciones 2018" };
            Aereo aereoIda = new Aereo { Nombre = "Aereo BUE-MDZ", Precio = 2000, Impuestos = 150 };
            Aereo aereoVuelta = new Aereo { Nombre = "Aereo MDZ-BUE", Precio = 2000, Impuestos = 150 };
            Hotel hotel = new Hotel { Nombre = "Hotel Hilton", Precio = 1000 };
            Auto auto = new Auto { Nombre = "Sedan 5 puertas", Precio = 100 };



            paquete.add(aereoIda);
            paquete.add(aereoVuelta);
            paquete.add(hotel);
            paquete.add(auto);

            Console.WriteLine(string.Concat("El Paquete consta de:", paquete.ObtenerNombre()));
            Console.WriteLine(string.Concat("El Paquete cuesta:", paquete.ObtenerPrecioTotal()));



            Console.WriteLine("Agregamos asistencia al viajeeo");
            AsistenciaViajero asisCard = new AsistenciaViajero { Nombre = "Cobertura Premium", Precio = 500, Impuestos = 20 };
            paquete.add(asisCard);

            Console.WriteLine(string.Concat("El Paquete consta de:", paquete.ObtenerNombre()));
            Console.WriteLine(string.Concat("El Paquete cuesta:", paquete.ObtenerPrecioTotal()));

            Console.WriteLine("Para no  aburrirse agregamos actividades al hotel");
            Actividad torneoPoker = new Actividad { Nombre = "Torneo PokerStar 2018", Precio = 50 };
            Actividad pileta = new Actividad { Nombre = "Acceso a pileta del hotel", Precio = 10 };
            hotel.add(torneoPoker);
            hotel.add(pileta);

            Console.WriteLine(string.Concat("El Hotel consta de:", hotel.ObtenerNombre()));
            Console.WriteLine(string.Concat("El hotel cuesta:", hotel.ObtenerPrecioTotal()));

            Console.WriteLine(string.Concat("El Paquete consta de:", paquete.ObtenerNombre()));
            Console.WriteLine(string.Concat("El Paquete cuesta:", paquete.ObtenerPrecioTotal()));

            Console.WriteLine("Es muy caro, sacar el torneo de poker");
            hotel.remove(torneoPoker);
            Console.WriteLine(string.Concat("El Hotel consta de:", hotel.ObtenerNombre()));
            Console.WriteLine(string.Concat("El hotel cuesta:", hotel.ObtenerPrecioTotal()));

            Console.WriteLine(string.Concat("El Paquete consta de:", paquete.ObtenerNombre()));
            Console.WriteLine(string.Concat("El Paquete cuesta:", paquete.ObtenerPrecioTotal()));

            Console.WriteLine("No me dieron las vacaciones :( cancalar todo");
            paquete.Cancelar();

            Console.ReadKey();


        }
    }
}
