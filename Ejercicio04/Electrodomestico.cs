namespace Ejercicio04;

class Electrodomestico
{
    //Enumerados - Opción1
    public enum Colores { Blanco, Negro, Rojo, Azul, Gris };
    public enum ConsumoEnergetico { A, B, C, D, E, F };

    //Constante
    //Opción 1
    protected const Colores COLOR = Colores.Blanco;
    protected const ConsumoEnergetico CONSUMO = ConsumoEnergetico.F;
    //Opción 2
    /*protected const string COLOR = "blanco";
    protected const char CONSUMO = 'F';*/
    protected const int PRECIO_BASE = 100;
    protected const int PESO = 5;

    //Atributos
    protected double _precioBase;
    private Colores _color;
    private ConsumoEnergetico _consumo;
    private double _peso;

    //Propiedades
    public double PrecioBase { get => _precioBase; }
    public Colores Color { get => _color; }
    public ConsumoEnergetico Consumo { get => _consumo; }
    public double Peso { get => _peso; }

    //Constructores
    public Electrodomestico(double precioBase, Colores color, ConsumoEnergetico consumo, double peso)
    {
        _precioBase = precioBase;
        _peso = peso;
        ComprobarConsumoEnergetico(consumo);
        ComprobarColor(color);
    }
    public Electrodomestico(double precioBase, double peso) : this(precioBase, COLOR, CONSUMO, peso) { }
    public Electrodomestico() : this(PRECIO_BASE, PESO) { }

    //Métodos
    private void ComprobarConsumoEnergetico(ConsumoEnergetico consumo)
    {
        //Opción 1
        if (consumo < ConsumoEnergetico.A || consumo > ConsumoEnergetico.F) _consumo = CONSUMO;
        //Opción 2
        /*if (letra < 'A' && letra > 'F') _consumo = CONSUMO;*/
        else _consumo = consumo;
    }

    private void ComprobarColor(Colores color)
    {
        //Opción 1
        if (color < Colores.Blanco || color > Colores.Gris) _color = COLOR;
        else _color = color;
        //Opción 2
        /*switch (color)
        {
            case "blanco":
            case "negro":
            case "rojo":
            case "azul":
            case "gris":
                _color = color;
                break;

            default:
                _color = COLOR;
                break;
        }*/
    }

    public virtual void PrecioFinal()
    {
        PrecioConsumo();
        PrecioPeso();
    }

    private void PrecioConsumo()
    {
        //Opción 1
        switch (Consumo)
        {
            case ConsumoEnergetico.A:
                _precioBase += 100;
                break;
            case ConsumoEnergetico.B:
                _precioBase += 80;
                break;
            case ConsumoEnergetico.C:
                _precioBase += 60;
                break;
            case ConsumoEnergetico.D:
                _precioBase += 50;
                break;
            case ConsumoEnergetico.E:
                _precioBase += 30;
                break;
            case ConsumoEnergetico.F:
                _precioBase += 10;
                break;
        }
        //Opción 2
        /*switch (consumoEnergetico)
        {
            case 'A':
                precioBase += 100;
                break;

            case 'B':
                precioBase += 80;
                break;

            case 'C':
                precioBase += 60;
                break;

            case 'D':
                precioBase += 50;
                break;

            case 'E':
                precioBase += 30;
                break;

            case 'F':
                precioBase += 10;
                break;
        }*/
    }

    private void PrecioPeso()
    {
        if (Peso >= 0 && Peso < 20)
            _precioBase += 10;
        else if (Peso < 50)
            _precioBase += 50;
        else if (Peso < 80)
            _precioBase += 80;
        else
            _precioBase += 100;
    }
}
