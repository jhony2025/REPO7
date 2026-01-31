using System;
using System.Collections.Generic;

class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }
}

class Programa
{
    static void Main()
    {
        Queue<Persona> cola = new Queue<Persona>();
        int capacidad = 30;

        for (int i = 1; i <= capacidad; i++)
        {
            cola.Enqueue(new Persona("Persona " + i));
        }

        Console.WriteLine("Asignación de asientos:\n");

        int asiento = 1;
        while (cola.Count > 0)
        {
            Persona p = cola.Dequeue();
            Console.WriteLine($"Asiento {asiento}: {p.Nombre}");
            asiento++;
        }

        Console.ReadKey();
    }
}
