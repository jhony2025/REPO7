public class Ejercicio9
{
    public static void Ejecutar()
    {
        ListaSimple lista1 = new ListaSimple();
        ListaSimple lista2 = new ListaSimple();

        Console.Write("Cantidad de datos para la primera lista: ");
        int n1 = int.Parse(Console.ReadLine());

        for (int i = 0; i < n1; i++)
        {
            Console.Write($"Lista 1 - Dato {i + 1}: ");
            lista1.InsertarFinal(double.Parse(Console.ReadLine()));
        }

        Console.Write("\nCantidad de datos para la segunda lista: ");
        int n2 = int.Parse(Console.ReadLine());

        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Lista 2 - Dato {i + 1}: ");
            lista2.InsertarFinal(double.Parse(Console.ReadLine()));
        }

        Nodo? a = lista1.head;
        Nodo? b = lista2.head;

        bool iguales = true;

        while (a != null && b != null)
        {
            if (a.Data != b.Data)
            {
                iguales = false;
                break;
            }
            a = a.Next;
            b = b.Next;
        }

        if (a != null || b != null)
            iguales = false;

        Console.WriteLine();
        if (iguales)
            Console.WriteLine("Las listas son iguales en tamaño y contenido.");
        else if (n1 == n2)
            Console.WriteLine("Las listas tienen el mismo tamaño pero diferente contenido.");
        else
            Console.WriteLine("Las listas no tienen el mismo tamaño ni contenido.");
    }
}
