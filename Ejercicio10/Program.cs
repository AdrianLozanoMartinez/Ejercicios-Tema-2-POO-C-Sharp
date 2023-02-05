namespace Ejercicio10;

class Program
{
    private const int CARTAS_A_COGER = 5;

    static void Main()
    {
        BarajaEspanola barajaEspanola = new BarajaEspanola(false);
        BarajaFrancesa barajaFrancesa = new BarajaFrancesa();

        Procesar(barajaEspanola);
        Procesar(barajaFrancesa);
    }

    static void Procesar<T>(Baraja<T> baraja) where T : Enum //Mandamos barajaEspanola/barajaFrancesa y sustituye el parámetro baraja
    {
        Console.WriteLine($"Hay {baraja.CartasDisponible()} cartas disponibles");

        baraja.CogerCarta();

        Console.WriteLine($"Hay {baraja.CartasDisponible()} cartas disponibles");
        baraja.MostrarMonton();

        baraja.Barajar();
        Carta<T>[] cartas = baraja.CogerCartas(CARTAS_A_COGER);

        for (int i = 0; i < cartas.Length; i++)
        {
            Carta<T> carta = cartas[i];
            Console.Write(carta);

            BarajaFrancesa barajaFrancesa = baraja as BarajaFrancesa;

            if (barajaFrancesa != null)
            {
                /*
                 * Las clases genéricas son invariantes, por tanto no se pueda castear directamente de
                 * Carta<T> a Carta<PalosBarajaFrancesa>, hay que castearlo primero a objeto y luego a
                 * Carta<PalosBarajaFrancesa>. Esto es porque si pasamos de Carta<T> a Carta<PalosBarajaFrancesa>,
                 * lo que estamos haciendo realmente es cambiar T por un tipo hijo (porque sigue siendo una Carta), 
                 * pero si primero lo casteamos a objeto, luego lo que estamos haciendo es castear de objeto a 
                 * Carta<PalosBarajaFrancesa>, solucionando así nuestro problema de invarianza. 
                 * Más información aquí:
                 * https://learn.microsoft.com/es-es/dotnet/standard/generics/covariance-and-contravariance
                 * https://www.ighniz.com/2018/11/24/csharp-invariantes-covariantes-y-contravariantes/
                 * https://geeks.ms/etomas/2010/11/18/c-bsico-covarianza-en-genricos/
                 */
                Carta<PalosBarajaFrancesa> cartaFrancesa = (Carta<PalosBarajaFrancesa>)(object)carta;
                bool esRoja = barajaFrancesa.EsRoja(cartaFrancesa);
                Console.Write($" Es {(esRoja ? "roja" : "negra")}");
            }

            Console.WriteLine();
        }

        baraja.MostrarBaraja();
    }
}