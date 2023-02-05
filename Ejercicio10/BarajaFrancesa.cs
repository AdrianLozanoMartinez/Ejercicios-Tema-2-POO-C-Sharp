namespace Ejercicio10;

public class BarajaFrancesa : Baraja<PalosBarajaFrancesa>
{
    //Constantes
    private const int CARTAS_PALO = 13;

    //Constructores
    public BarajaFrancesa() : base()
    {
        CrearBaraja();
    }

    //Métodos
    public override void CrearBaraja()
    {
        int numeroPalos = Enum.GetValues<PalosBarajaFrancesa>().Length;
        cartasPorPalo = CARTAS_PALO;
        numeroCartas = cartasPorPalo * numeroPalos;
        cartas = new Carta<PalosBarajaFrancesa>[numeroCartas];

        for (int numeroPalo = 0; numeroPalo < numeroPalos; numeroPalo++)
        {
            PalosBarajaFrancesa palo = (PalosBarajaFrancesa)numeroPalo;

            for (int numero = 1; numero <= cartasPorPalo; numero++)
            {
                int posicion = numero - 1 + numeroPalo * cartasPorPalo;
                cartas[posicion] = new Carta<PalosBarajaFrancesa>(numero, palo);
            }
        }
    }

    public bool EsRoja(Carta<PalosBarajaFrancesa> carta) => carta.Palo == PalosBarajaFrancesa.Corazones || carta.Palo == PalosBarajaFrancesa.Diamantes;

    public bool EsNegra(Carta<PalosBarajaFrancesa> carta) => carta.Palo == PalosBarajaFrancesa.Treboles || carta.Palo == PalosBarajaFrancesa.Picas;
}
