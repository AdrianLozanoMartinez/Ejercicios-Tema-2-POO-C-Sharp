using System.Text;

namespace Ejercicio05;

class Cuenta
{
    //Atributos
    private Persona _titular;
    private double _cantidad;

    //Propiedades
    public Persona Titular { get => _titular; set => _titular = value; }
    public double Cantidad { get => _cantidad; set => _cantidad = value; }

    //Constructores
    public Cuenta(Persona titular, double cantidad)
    {
        Titular = titular;
        Cantidad = cantidad;
    }
    public Cuenta(Persona titular) : this(titular, 0) { }

    //Métodos
    public override string ToString()
    {
        return $"Titular: {Titular}, Cantidad: {Cantidad} euros";
    }

    public void Ingresar(double cantidad)
    {
        if (cantidad > 0) Cantidad += cantidad;
    }

    public virtual void Retirar(double cantidad)
    {
        Cantidad -= cantidad;
    }
}
