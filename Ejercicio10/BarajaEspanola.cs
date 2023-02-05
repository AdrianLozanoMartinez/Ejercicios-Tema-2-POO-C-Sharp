using Ejercicio10;

public class BarajaEspanola : Baraja<PalosBarajaEspanola>
{
    //Constantes
    private const int CARTAS_PALO = 10;
    private const int CARTAS_EXTENDIDA = 12;

    //Atributos
    private bool extendida;

    //Constructores
    public BarajaEspanola(bool extendida) : base()
    {
        this.extendida = extendida;
        CrearBaraja();
    }

    //Métodos
    public override void CrearBaraja()
    {
        int numeroPalos = Enum.GetValues<PalosBarajaEspanola>().Length;
        cartasPorPalo = extendida ? CARTAS_EXTENDIDA : CARTAS_PALO;
        numeroCartas = cartasPorPalo * numeroPalos;
        cartas = new Carta<PalosBarajaEspanola>[numeroCartas];

        for (int numeroPalo = 0; numeroPalo < numeroPalos; numeroPalo++)
        {
            PalosBarajaEspanola palo = (PalosBarajaEspanola)numeroPalo;

            for (int numero = 1; numero <= CARTAS_EXTENDIDA; numero++)
            {
                if (extendida || numero < 8 || numero > 9)
                {
                    int posicion = numero - 1 + numeroPalo * cartasPorPalo;
                    if (!extendida && numero > 7) posicion -= 2;
                    cartas[posicion] = new Carta<PalosBarajaEspanola>(numero, palo);
                }
            }
        }
    }
}