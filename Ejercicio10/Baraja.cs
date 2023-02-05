namespace Ejercicio10;

public abstract class Baraja<T> where T : Enum
{
    //Atributos
    protected Carta<T>[] cartas;
    protected int posicionSiguienteCarta;
    protected int numeroCartas;
    protected int cartasPorPalo;

    //Constructores
    public Baraja()
    {
        posicionSiguienteCarta = 0;
    }

    //Métodos
    public abstract void CrearBaraja();

    public void Barajar()
    {
        Random random = new Random();

        for (int i = 0; i < cartas.Length; i++)
        {
            Carta<T> aux = cartas[i];
            int position = random.Next(cartas.Length);
            cartas[i] = cartas[position];
            cartas[position] = aux;
        }

        posicionSiguienteCarta = 0;
    }

    public int CartasDisponible() => cartas.Length - posicionSiguienteCarta;

    public Carta<T> CogerCarta()
    {
        Carta<T> result;

        if (posicionSiguienteCarta < numeroCartas)
        {
            result = cartas[posicionSiguienteCarta];
            posicionSiguienteCarta++;
        }
        else
        {
            result = null;
            Console.WriteLine("No hay más cartas, vuelve a barajar");
        }

        return result;
    }

    public Carta<T>[] CogerCartas(int cantidad)
    {
        Carta<T>[] result = null;

        if (cantidad > numeroCartas) Console.WriteLine("No se puede dart más caras de las que hay");
        else if (cantidad > CartasDisponible()) Console.WriteLine("No suficientes cartas disponible");
        else
        {
            result = new Carta<T>[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                result[i] = CogerCarta();
            }
        }

        return result;
    }

    public void MostrarMonton()
    {
        if (posicionSiguienteCarta == 0) Console.WriteLine("Todavía no se ha sacado ninguna carta");
        else
        {
            for (int i = 0; i < posicionSiguienteCarta; i++)
            {
                Console.WriteLine(cartas[i]);
            }
        }
    }

    public void MostrarBaraja()
    {
        if (posicionSiguienteCarta == cartas.Length) Console.WriteLine("No hay cartas que mostrar");
        else
        {
            for (int i = posicionSiguienteCarta; i < cartas.Length; i++)
            {
                Console.WriteLine(cartas[i]);
            }
        }
    }
}
