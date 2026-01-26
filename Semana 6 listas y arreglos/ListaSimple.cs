public class ListaSimple
{
    public Nodo? head;

    public ListaSimple()
    {
        head = null;
    }

    public void InsertarFinal(double dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (head == null)
        {
            head = nuevo;
        }
        else
        {
            Nodo actual = head;
            while (actual.Next != null)
            {
                actual = actual.Next;
            }
            actual.Next = nuevo;
        }
    }

    public void Mostrar()
    {
        Nodo? actual = head;
        while (actual != null)
        {
            Console.Write(actual.Data + " ");
            actual = actual.Next;
        }
        Console.WriteLine();
    }
}
