namespace Ejercicio04;

class Program
{
    static void Main()
    {
        //Opción 1
        Electrodomestico[] electrodomestico = new Electrodomestico[10]
        {
                new Electrodomestico(120, Electrodomestico.Colores.Blanco, Electrodomestico.ConsumoEnergetico.D, 25),
                new Electrodomestico(115, 15),
                new Electrodomestico(),
                new Lavadora(30, 200, Electrodomestico.Colores.Gris, Electrodomestico.ConsumoEnergetico.A, 10),
                new Lavadora(250, 50),
                new Lavadora(),
                new Television(1080, true, 1200.95, Electrodomestico.Colores.Rojo, Electrodomestico.ConsumoEnergetico.C, 3),
                new Television(720, false, 582, Electrodomestico.Colores.Azul, Electrodomestico.ConsumoEnergetico.B, 5),
                new Television(650, 1.5),
                new Television()
        };

        //Opción 2
        /*Electrodomestico[] electrodomesticos = new Electrodomestico[3];

        electrodomesticos[0] = new Electrodomestico(20, 40);
        electrodomesticos[1] = new Lavadora(90, 60);
        electrodomesticos[2] = new Television(10, 20);*/

        double precioElectrodomesticos = 0;
        double precioLavadoras = 0;
        double precioTelevisores = 0;

        foreach (Electrodomestico electro in electrodomestico)
        {
            electro.PrecioFinal();

            precioElectrodomesticos += electro.PrecioBase;

            if (electro is Lavadora)
                precioLavadoras += electro.PrecioBase;
            else if (electro is Television)
                precioTelevisores += electro.PrecioBase;
        }

        Console.WriteLine($"Precio total electrodomesticos: {precioElectrodomesticos}");
        Console.WriteLine($"Precio total lavadoras: {precioLavadoras}");
        Console.WriteLine($"Precio total televisores: {precioTelevisores}");
    }
}