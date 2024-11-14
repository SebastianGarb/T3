using T3;

byte opcion1;
string opcion2;
Cita[] citas = new Cita[0];
do
{
    Console.WriteLine("Bienvenido al registro academico");
    Console.WriteLine(" * Que desea hacer: ");
    Console.WriteLine("  1.  Crear");
    Console.WriteLine("  2.  Lista");
    Console.WriteLine("  3.  Modificar Universidades");
    Console.WriteLine("  4.  Fin");
    Console.WriteLine("---------------------------------");

    Console.WriteLine("\nIngrese una opcion [1-4]");
    while (!byte.TryParse(Console.ReadLine(), out opcion1) || opcion1 > 4)
    {
        Console.Write("Error: Ingrese opcion: ");
    }

    switch (opcion1)
    {
        case 1:
            CitaUtil.CrearCita(citas);
            break;
        case 2:
            CitaUtil.ListarCitas(citas);
            break;
        case 3:
            break;
        case 4:
            Environment.Exit(0);
            break;

    }
    Console.WriteLine("Quieres regresar al menu? (si/no)");
    opcion2 = Console.ReadLine();
} while (opcion2 == "si");