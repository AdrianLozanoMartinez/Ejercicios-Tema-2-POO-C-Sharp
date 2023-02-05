namespace Ejercicio08;

class Program
{
    static void Main(string[] args)
    {
        Empleado repartidor1 = new Repartidor("Adri", 37, 1200, "zona 3");
        Empleado repartidor2 = new Repartidor("Marina", 24, 1100, "zona 3");
        Empleado comercial1 = new Comercial("Aaron", 38, 600, 300);
        Empleado comercial2 = new Comercial("Jose", 48, 2500, 200);

        repartidor1.AplicarPlus();
        repartidor2.AplicarPlus();
        comercial1.AplicarPlus();
        comercial2.AplicarPlus();

        Console.WriteLine($"Repartidor 1: {repartidor1.Salario}");
        Console.WriteLine($"Repartidor 2: {repartidor2.Salario}");
        Console.WriteLine($"Comercial 1: {comercial1.Salario}");
        Console.WriteLine($"Comercial 1: {comercial2.Salario}");
    }
}