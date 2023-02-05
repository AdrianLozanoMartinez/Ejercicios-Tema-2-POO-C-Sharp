using System.Net;
using System.Text;

namespace Ejercicio05;

class Persona
{
    //Constante
    private const string LETRA = "trwagmyfpdxbnjzsqvhlcke";
    private const int MAYOR_EDAD = 18;

    //Atributos
    private string _nombre;
    private int _edad;
    private string _dni;

    //Propiedades
    public string Nombre { get => _nombre; set => _nombre = value; }
    public int Edad { get => _edad; set => _edad = value; }
    //Opción 1
    public string Dni { get => _dni; set => _dni = value; }
    //Opción 2
    //public string Dni { get => _dni; set => _dni = value + CalcularLetraDni(value); }

    //Constructor
    public Persona(string nombre, int edad, string dni)
    {
        Nombre = nombre;
        Edad = edad;
        //Opción 1
        Dni = CalcularLetra(dni);
        //Opción 2
        //Dni = dni;
    }

    //Métodos
    //Opción 1
    private string CalcularLetra(string dni)
    {
        int numero = int.Parse(dni);
        string dniCompleto = dni + LETRA[numero % LETRA.Length];

        return dniCompleto;
    }

    //Opción 2
    /*private char CalcularLetra(string dni)
    {
        int numero = int.Parse(dni);
        int resto = numero % LETRA.Length;

        return LETRA[resto];
    }*/

    public bool EsMayorDeEdad() => Edad >= MAYOR_EDAD;

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad} años, Dni: {Dni}";
    }
}
