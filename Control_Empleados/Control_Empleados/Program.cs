using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            string nombre, apellido, nip;

            Console.WriteLine("Bienbenido a Monsters Inc.\n");
            Console.WriteLine("Ingrese los campos que se solicitan:\n");

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Digite su NIP para asignarlo a su tarjeta bancaria: ");
            nip = Console.ReadLine();

            Empleado empleado1 = new Empleado(nombre, apellido)
            {
                Nip = nip
            };

            Console.WriteLine(empleado1.ToString());
            Console.ReadKey();
        }
    }
}
