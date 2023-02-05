namespace Ejercicio03;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indique longitud del tamaño del array de password");
        int tamano = int.Parse(Console.ReadLine());
        Console.WriteLine("Indique longitud de la password");
        int longitud = int.Parse(Console.ReadLine());

        Password[] password = new Password[tamano];
        bool[] booleanos = new bool[password.Length];

        for (int i = 0; i < password.Length; i++)
        {
            password[i] = new Password(longitud);
            booleanos[i] = password[i].EsFuerte();

            Console.WriteLine($"Contraseña: {password[i].Contrasena}, | Es fuerte: {booleanos[i]}");
        }
    }
}