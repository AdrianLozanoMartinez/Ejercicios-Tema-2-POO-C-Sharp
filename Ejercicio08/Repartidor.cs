using System.Text;

namespace Ejercicio08;

class Repartidor : Empleado
{
    //Constantes
    private const int EDAD = 25;
    private const string ZONA = "zona 3";

    //Atributos
    private string _zona;

    //Propiedades
    public string Zona { get => _zona; set => _zona = value; }

    //Constructores
    public Repartidor(string nombre, int edad, double salario, string zona) 
        : base(nombre, edad, salario)
    {
        Zona = zona;
    }

    //Métodos
    public override string ToString()
    {
        //Opción 1
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Zona: {Zona}");
        return base.ToString() + builder;

        //Opción 2
        //return base.ToString() + $", Zona: {Zona}";
    }

    public override void AplicarPlus()
    {
        if (Edad < EDAD && Zona == ZONA) Salario += PLUS;
    }
}
