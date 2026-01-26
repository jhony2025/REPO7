public class Agenda
{
    private Contacto[] contactos;
    private int contador;

    public Agenda(int tamaño)
    {
        contactos = new Contacto[tamaño];
        contador = 0;
    }

    // Agregar contacto
    public void AgregarContacto(Contacto contacto)
    {
        if (contador < contactos.Length)
        {
            contactos[contador] = contacto;
            contador++;
            Console.WriteLine("Contacto agregado correctamente.");
        }
        else
        {
            Console.WriteLine("La agenda está llena.");
        }
    }

    // Buscar contacto
    public void BuscarContacto(string nombre)
    {
        bool encontrado = false;

        for (int i = 0; i < contador; i++)
        {
            if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                contactos[i].Mostrar();
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }

    // Eliminar contacto
    public void EliminarContacto(string nombre)
    {
        for (int i = 0; i < contador; i++)
        {
            if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                for (int j = i; j < contador - 1; j++)
                {
                    contactos[j] = contactos[j + 1];
                }

                contactos[contador - 1] = null;
                contador--;
                Console.WriteLine("Contacto eliminado.");
                return;
            }
        }

        Console.WriteLine("Contacto no encontrado.");
    }

    // Reportería
    public void MostrarAgenda()
    {
        Console.WriteLine("\n--- LISTADO DE CONTACTOS ---");

        if (contador == 0)
        {
            Console.WriteLine("Agenda vacía.");
            return;
        }

        for (int i = 0; i < contador; i++)
        {
            contactos[i].Mostrar();
        }
    }
}
