using System;

namespace Control_Empleados
{
    public class Empleado
    {
        private readonly string nombre;
        private readonly string apellido;
        private readonly string id;
        private readonly string locker;
        private readonly string banco;
        private readonly Random random = new Random();

        public Empleado(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            id = GenerarID();
            locker = GenerarLocker();
            banco = AsignaBanco();
        }

        public string Nip { get; set; }


        private string GenerarID()
        {
            int numero;
            string id = String.Empty;

            for (int i = 0; i < 10; i++)
            {
                numero = random.Next(10);
                id += numero.ToString();
            }

            return id;
        }

        private string GenerarLocker()
        {
            int numero;
            string locker = String.Empty;

            for (int i = 0; i < 2; i++)
            {
                numero = random.Next(10);
                locker += numero.ToString();
            }

            return locker;
        }

        private string AsignaBanco()
        {            
            int asignarBanco;
            string banco = String.Empty;

            asignarBanco = random.Next(1, 3);

            switch (asignarBanco)
            {
                case 1:
                    banco = "Santander";
                    break;
                case 2:
                    banco = "BBVA";
                    break;
            }

            return banco;
        }

        public override string ToString()
        {
            string mensaje = $"\nEmpleado: {nombre} {apellido}\nNúmero de empleado: {id}\nLocker No: {locker}\nBanco asignado: {banco}";
            return mensaje;
        }
    }
}
