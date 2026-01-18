public class Ejercicio8
{
    public static void Ejecutar()
    {
        ListaSimple listaPrincipal = new ListaSimple();
        ListaSimple menoresIguales = new ListaSimple();
        ListaSimple mayores = new ListaSimple();

        Console.Write("Ingrese la cantidad de datos: ");
        int n = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el dato {i + 1}: ");
            double valor = double.Parse(Console.ReadLine());
            listaPrincipal.InsertarFinal(valor);
            suma += valor;
        }

        double promedio = suma / n;

        Nodo? actual = listaPrincipal.head;
        while (actual != null)
        {
            if (actual.Data <= promedio)
                menoresIguales.InsertarFinal(actual.Data);
            else
                mayores.InsertarFinal(actual.Data);

            actual = actual.Next;
        }

        Console.WriteLine("\nLista principal:");
        listaPrincipal.Mostrar();

        Console.WriteLine($"Promedio: {promedio}");

        Console.WriteLine("Datos menores o iguales al promedio:");
        menoresIguales.Mostrar();

        Console.WriteLine("Datos mayores al promedio:");
        mayores.Mostrar();
    }
}

