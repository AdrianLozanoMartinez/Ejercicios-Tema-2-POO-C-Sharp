using System.Text;

namespace Ejercicio02;

class Persona
{
    //Enumerados
    public enum Genero { Hombre, Mujer };

    //Constante
    private const Genero SEXO = Genero.Hombre;

    public const int SOBREPESO = 1;
    public const int IDEAL = 0;
    public const int DELGADO = -1;

    private const int MAYOREDAD = 18;
    private const string LETRA = "trwagmyfpdxbnjzsqvhlcke";

    //Atributos
    private string _nombre;
    private int _edad;
    private string _dni;
    private Genero _sexo;
    private double _peso;
    private double _altura;

    //Propiedades
    public string Nombre { set => _nombre = value; }
    public int Edad { set => _edad = value; }
    public Genero Sexo { set => _sexo = value; }
    public double Peso { set => _peso = value; }
    public double Altura { set => _altura = value; }

    //Constructores
    public Persona(string nombre, int edad, Genero sexo, double peso, double altura)
    {
        Nombre = nombre;
        Edad = edad;
        Sexo = sexo;
        Peso = peso;
        Altura = altura;
        _dni = GeneraDNI();
    }
    public Persona(string nombre, int edad, Genero sexo) : this(nombre, edad, sexo, 0, 0) { }
    public Persona() : this(string.Empty, 0, SEXO) { }

    //Métodos
    public int CalcularIMC()
    {
        int result = IDEAL;
        double imc = _peso / Math.Pow(_altura, 2);

        if (imc < 20) result = DELGADO;
        else if (imc > 25) result = SOBREPESO;

        return result;
    }

    public bool EsMAyorDeEdad() => _edad >= MAYOREDAD;  //Equivale a return, cuando hay una sola línea se puede simplificar a una flecha

    //Opción1
    private string GeneraDNI()
    {
        Random random = new Random();
        string numeroDNI = "";
        char letra = ' ';

        for (int i = 0; i < 8; i++)
        {
            numeroDNI += random.Next(0, 10);
        }

        letra = LETRA[int.Parse(numeroDNI) % LETRA.Length];
        return numeroDNI + letra;
    }
    //Opción2
    /*private string GenerarDNI()
    {
        int numero = GenerarNumeroAleatorio();
        char letra = DNI_LETTERS[numero % DNI_LETTERS.Length];

        return numero.ToString() + letra;
    }

    private int GenerarNumeroAleatorio()
    {
        Random random = new Random();

        return random.Next(1, 100000000);
    }*/

    //Métodos heredados
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append($"Nombre: {_nombre}, Edad: {_edad}, DNI: {_dni}, Sexo: {_sexo}");
        builder.AppendLine($" Peso: {_peso}, Altura: {_altura}");
        return builder.ToString();
    }
}
