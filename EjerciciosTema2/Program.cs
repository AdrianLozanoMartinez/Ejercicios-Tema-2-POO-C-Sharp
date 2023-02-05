using Ejercicio01;

namespace EjerciciosTema2;

class Program
{
    static void Main()
    {
        //Crear instancias
        Cuenta cuenta1 = new Cuenta("Aarón");
        Cuenta cuenta2 = new Cuenta("Marina", 1025);

        //Aplicar métodos
        cuenta1.Ingresar(100);
        cuenta2.Ingresar(100);

        cuenta1.Retirar(5);
        cuenta2.Retirar(250);

        //Mostrar
        Console.WriteLine(cuenta1);
        Console.WriteLine(cuenta2);
    }
}