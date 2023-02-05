using System.Globalization;

namespace Ejercicio02;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Introduce el nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("Introduce la edad");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el sexo");
        Persona.Genero sexo = (Persona.Genero)Enum.Parse(typeof(Persona.Genero), Console.ReadLine(), true);
        Console.WriteLine("Introduce el peso");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduce la altura");
        double altura = double.Parse(Console.ReadLine());

        Persona persona1 = new Persona(nombre, edad, sexo, peso, altura);
        Persona persona2 = new Persona(nombre, edad, sexo);
        Persona persona3 = new Persona();

        persona3.Nombre = "Aaron";
        persona3.Edad = 14;
        persona3.Sexo = Persona.Genero.Hombre;
        persona3.Peso = 80;
        persona3.Altura = 1.65;

        ComprobarPeso(persona1);
        ComprobarPeso(persona2);
        ComprobarPeso(persona3);

        MayorEdad(persona1);
        MayorEdad(persona2);
        MayorEdad(persona3);

        Console.WriteLine(persona1);
        Console.WriteLine(persona2);
        Console.WriteLine(persona3);
    }

    static void ComprobarPeso(Persona persona)
    {
        int imc = persona.CalcularIMC();

        if (imc == Persona.SOBREPESO) Console.WriteLine("Obeso");
        else if (imc == Persona.IDEAL) Console.WriteLine("Peso ideal");
        else Console.WriteLine("Delgado");
    }

    static void MayorEdad(Persona persona)
    {
        if (persona.EsMAyorDeEdad()) Console.WriteLine("Es mayor de edad");
        else Console.WriteLine("Es menor");
    }
}