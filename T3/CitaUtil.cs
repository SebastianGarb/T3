using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class CitaUtil
    {
        private static int contadorCitas = 0;
        public static void CrearCita(Cita[] citas)
        {
            string seguir;
            
            if (contadorCitas < citas.Length)
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

                citas[contadorCitas] = nuevaCita;

                contadorCitas++;

                Console.WriteLine("Cita creada exitosamente.");
            }
        }

        public static void ListarCitas(Cita[] citas)
        {
            double sumaTotal = 0;
            foreach (var cita in citas)
            {
                Console.WriteLine(cita.ToString());
                sumaTotal += cita.Precio;
            }
            Console.WriteLine($"\nSuma total de los precios: {sumaTotal:C}");

        }

        public static void ModificarUniversidad(Cita[] citas, string textoAntiguo, string textoNuevo)
        {
            for (int i = 0; i < contadorCitas; i++)
            {
                if (citas[i].Estudiante.Universidad.Contains(textoAntiguo))
                {
                    citas[i].Estudiante.Universidad = citas[i].Estudiante.Universidad.Replace(textoAntiguo, textoNuevo);
                }
            }
            Console.WriteLine("Modificación masiva completada.");
        }
    }
}
