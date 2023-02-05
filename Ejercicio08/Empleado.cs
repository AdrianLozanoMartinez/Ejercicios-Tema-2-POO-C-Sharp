using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio08;

abstract class Empleado
{
    //Constantes
    protected const int PLUS = 300;

    //Atributos
    private string _nombre;
    private int _edad;
    private double _salario;

    //Propiedades
    public string Nombre { get => _nombre; set => _nombre = value; }
    public int Edad { get => _edad; set => _edad = value; }
    public double Salario { get => _salario; set => _salario = value; }

    //Constructores
    public Empleado(string nombre, int edad, double salario)
    {
        Nombre = nombre;
        Edad = edad;
        Salario = salario;
    }

    //Métodos
    public override string ToString()
    {
        //Opción 1
        StringBuilder builder = new StringBuilder();
        builder.Append($"Nombre: {Nombre}, Edad: {Edad}, Salario: {Salario} ");
        return builder.ToString();

        //Opción 2
        //return $"Nombre: {Nombre}, Edad: {Edad}, Salario: {Salario}";
    }

    public abstract void AplicarPlus();
}
