namespace Ejercicio09;

class Program
{
    static void Main()
    {
        const int TAMANO = 2;
        const int NUMEROS = 20;

        Lista<int> lista = new Lista<int>(TAMANO);
        Random random = new Random();

        for (int i = 0; i < NUMEROS; i++)
        {
            lista.Add(random.Next(1, 11));
        }
        Console.WriteLine(lista);
        Console.WriteLine(lista.Get(10));

        for (int i = 1; i <= 10; i++)
        {
            lista.Remove(i);
        }

        Console.WriteLine(lista);
    }
}