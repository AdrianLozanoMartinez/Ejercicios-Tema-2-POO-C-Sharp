using System.Text;

namespace Ejercicio01;

class Cuenta
{
    //Atributos
    private string _titular;
    private double _cantidad;

    //Propiedades
    public string Titular { get => _titular; set => _titular = value; }
    public double Cantidad { get => _cantidad; set => _cantidad = value; }

    //Constructores
    public Cuenta(string titular, double cantidad)
    {
        _titular = titular;
        _cantidad = cantidad;
    }
    public Cuenta(string titular) : this(titular, 0) { }

    //Métodos hererados
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Titular: {Titular}, Cantidad: {Cantidad}");
        return builder.ToString();
    }

    //Métodos
    public void Ingresar(double cantidad)
    {
        if (cantidad > 0) Cantidad += cantidad;
    }

    public void Retirar(double cantidad)
    {
        //Opción 1
        Cantidad -= cantidad;

        if (Cantidad < 0) Cantidad = 0;

        //Opción 2
        //Cantidad = Math.Max(0, Cantidad - cantidad); //Es un if, coge el máximo entre 0 y la resta, si da positivo coge ese número, si da negativo coge 0
    }
}
