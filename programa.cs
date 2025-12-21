class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda(10);
        int opcion;

        do
        {
            Console.WriteLine("\nAGENDA TELEFÓNICA");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Buscar contacto");
            Console.WriteLine("3. Eliminar contacto");
            Console.WriteLine("4. Mostrar agenda (Reportería)");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese teléfono: ");
                    string telefono = Console.ReadLine();

                    agenda.AgregarContacto(new Contacto(nombre, telefono));
                    break;

                case 2:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    agenda.BuscarContacto(buscar);
                    break;

                case 3:
                    Console.Write("Ingrese el nombre a eliminar: ");
                    string eliminar = Console.ReadLine();
                    agenda.EliminarContacto(eliminar);
                    break;

                case 4:
                    agenda.MostrarAgenda();
                    break;

                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 5);
    }
}
