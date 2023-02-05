namespace Ejercicio05;

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona("Marina", 20, "123456789");
        Persona persona2 = new Persona("Adri", 40, "987654321");

        Cuenta cuenta1 = new Cuenta(persona1);

        CuentaJoven cuentaJoven1 = new CuentaJoven(persona1, 10);
        CuentaJoven cuentaJoven2 = new CuentaJoven(persona2, 10);

        cuenta1.Ingresar(1000);
        cuentaJoven1.Ingresar(1000);
        cuentaJoven2.Ingresar(1000);

        cuenta1.Retirar(500);
        cuentaJoven1.Retirar(600);
        cuentaJoven2.Retirar(50);

        Console.WriteLine($"{persona1}");
        Console.WriteLine($"{persona2}");
        Console.WriteLine();
        Console.WriteLine($"{cuenta1}");
        Console.WriteLine($"{cuentaJoven1}");
        Console.WriteLine($"{cuentaJoven2}");
    }
}