using System.Text;

namespace Ejercicio08;

class Comercial : Empleado
{
    //Constantes
    private const int EDAD = 30;
    private const int SALARIO = 200;

    //Atributos
    private double _comision;

    //Propiedades
    public double Comision { get => _comision; set => _comision = value; }

    //Constructores
    public Comercial(string nombre, int edad, double salario, double comision)
            : base(nombre, edad, salario)
    {
        Comision = comision;
    }

    //Métodos
    public override string ToString()
    {
        //Opción 1
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Comisión: {Comision}");
        return base.ToString() + builder;

        //Opción 2
        //return base.ToString() + $", Comision: {Comision}";
    }

    public override void AplicarPlus()
    {
        if (Edad > EDAD && Comision > SALARIO) Salario += PLUS;
    }
}
