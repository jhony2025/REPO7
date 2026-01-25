using System;
using System.Collections.Generic;

class ProgramaCombinado
{
    /// <summary>
    /// Verifica si una expresión tiene paréntesis, llaves y corchetes balanceados.
    /// </summary>
    /// <param name="expresion">Cadena de la expresión matemática</param>
    /// <returns>true si está balanceada, false si no</returns>
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0) return false;

                char ultimo = pila.Pop();

                if ((c == ')' && ultimo != '(') ||
                    (c == '}' && ultimo != '{') ||
                    (c == ']' && ultimo != '['))
                {
                    return false;
                }
            }
        }

        return pila.Count == 0;
    }

    /// <summary>
    /// Mueve discos de la torre origen a la torre destino usando la torre auxiliar
    /// </summary>
    /// <param name="n">Número de discos</param>
    /// <param name="origen">Pila de origen</param>
    /// <param name="destino">Pila de destino</param>
    /// <param name="auxiliar">Pila auxiliar</param>
    /// <param name="origenName">Nombre de la torre origen</param>
    /// <param name="destinoName">Nombre de la torre destino</param>
    /// <param name="auxName">Nombre de la torre auxiliar</param>
    static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                            string origenName, string destinoName, string auxName)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {origenName} a {destinoName}");
            return;
        }

        MoverDiscos(n - 1, origen, auxiliar, destino, origenName, auxName, destinoName);
        MoverDiscos(1, origen, destino, auxiliar, origenName, destinoName, auxName);
        MoverDiscos(n - 1, auxiliar, destino, origen, auxName, destinoName, origenName);
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("=== Menú de Programa Combinado ===");
            Console.WriteLine("1. Verificar paréntesis balanceados");
            Console.WriteLine("2. Resolver Torres de Hanoi");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción (1-3): ");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingresa la expresión matemática: ");
                string expresion = Console.ReadLine();

                if (EstaBalanceada(expresion))
                    Console.WriteLine("Fórmula balanceada.\n");
                else
                    Console.WriteLine("Fórmula NO balanceada.\n");
            }
            else if (opcion == "2")
            {
                Console.Write("Ingresa el número de discos: ");
                int numDiscos;
                while (!int.TryParse(Console.ReadLine(), out numDiscos) || numDiscos <= 0)
                {
                    Console.Write("Por favor, ingresa un número válido mayor que 0: ");
                }

                Stack<int> torreA = new Stack<int>();
                Stack<int> torreB = new Stack<int>();
                Stack<int> torreC = new Stack<int>();

                for (int i = numDiscos; i >= 1; i--)
                    torreA.Push(i);

                Console.WriteLine("Movimientos para resolver Torres de Hanoi:");
                MoverDiscos(numDiscos, torreA, torreC, torreB, "A", "C", "B");
                Console.WriteLine();
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida, intenta de nuevo.\n");
            }
        }
    }
}
