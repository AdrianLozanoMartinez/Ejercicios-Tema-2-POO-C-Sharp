namespace Ejercicio04;

class Lavadora : Electrodomestico
{
    //Constantes
    private const double CARGA = 5;

    //Atributos
    private double _carga;

    //Propiedades
    public double Carga { get => _carga; }

    //Constructores
    public Lavadora(double carga, double precioBase, Colores color, ConsumoEnergetico consumo, double peso)
        : base(precioBase, color, consumo, peso)
    {
        _carga = carga;
    }
    public Lavadora(double precioBase, double peso) : this(CARGA, precioBase, COLOR, CONSUMO, peso) { }
    public Lavadora() : this(PRECIO_BASE, PESO) { }

    //Métodos
    public override void PrecioFinal()
    {
        base.PrecioFinal();

        if (Carga > 30) _precioBase += 50;
    }
}
