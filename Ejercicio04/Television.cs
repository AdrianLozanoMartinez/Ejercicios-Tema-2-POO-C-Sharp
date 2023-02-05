namespace Ejercicio04;

class Television : Electrodomestico
{
    //Constantes
    private const int RESOLUCION = 20;
    private const bool TDT = false;

    //Atributos
    private int _resolucion;
    private bool _tdt;

    //Propiedades
    public int Resolucion { get => _resolucion; }
    public bool Tdt { get => _tdt; }

    //Constructores
    public Television(int resolucion, bool tdt, double precioBase, Colores color, ConsumoEnergetico consumo, double peso)
        : base(precioBase, color, consumo, peso)
    {
        _resolucion = resolucion;
        _tdt = tdt;
    }
    public Television(double precioBase, double peso)
        : this(RESOLUCION, TDT, precioBase, COLOR, CONSUMO, peso) { }
    public Television() : this(PRECIO_BASE, PESO) { }

    //Métodos
    public override void PrecioFinal()
    {
        base.PrecioFinal();

        if (Resolucion > 40) _precioBase *= 1.3; // 30/100 + 1

        if (Tdt == true) _precioBase += 50;
    }
}
