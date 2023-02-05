using System.Text;

namespace Ejercicio05;

class CuentaJoven : Cuenta
{
    //Constantes
    private const int EDAD_MINIMA = 25;

    //Atributos
    private double _bonificacion;

    //Propiedades
    public double Bonificacion { get => _bonificacion; set => _bonificacion = value; }

    //Constructor
    public CuentaJoven(Persona titular, double cantidad, double bonificacion) : base(titular, cantidad)
    {
        Bonificacion = bonificacion;
    }
    public CuentaJoven(Persona titular, double bonificacion) : this(titular, 0, bonificacion) { }

    //Método
    //Opción 1
    //Método
    public bool EsTitularValido() => Titular.EsMayorDeEdad() && Titular.Edad <= EDAD_MINIMA;

    //Opción 2
    /*public bool EsTitularValido()
    {
        return Titular.EsMayorDeEdad() && Titular.Edad <= 25;
    }*/

    public override void Retirar(double cantidad)
    {
        if (EsTitularValido()) base.Retirar(cantidad);
    }

    public override string ToString()
    {
        return $"Cuenta Joven, Bonificación: {Bonificacion}, {base.ToString()}";
    }
}
