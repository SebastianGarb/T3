using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class CitaUtil
    {
        public static void CrearCita(List<Cita> citas)
        {
            Console.Write("Ingrese el número de la cita: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el código del estudiante: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la universidad del estudiante: ");
            string universidad = Console.ReadLine();

            Estudiante estudiante = new Estudiante(codigo, nombre, universidad);

            Console.Write("Ingrese la enfermedad: ");
            string enfermedad = Console.ReadLine();

            Console.Write("Ingrese el precio de la cita: ");
            double precio = double.Parse(Console.ReadLine());

            Cita nuevaCita = new Cita(numero, estudiante, enfermedad, precio);
            
            Console.WriteLine("Cita creada exitosamente.");
        }
    }
}
