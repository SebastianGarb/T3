using T3;

byte opcion1;
List<Cita> citas = new List<Cita>();
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
        break;
    case 3:
        break;
    case 4:
        Environment.Exit(0);
        break;

}
