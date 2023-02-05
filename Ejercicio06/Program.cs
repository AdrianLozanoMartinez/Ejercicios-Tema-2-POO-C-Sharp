namespace Ejercicio06;

class Program
{
    static void Main()
    {
        Cancion cancion1 = new Cancion("Take on me", "A-ha");
        Cancion cancion2 = new Cancion("Africa", "Toto");
        Cancion cancion3 = new Cancion("Don't stop believin", "Journey");

        CompactDisc cd = new CompactDisc(2);

        cd.Agregar(cancion1);

        Console.WriteLine($"Hay {cd.NumeroCanciones} canciones");

        cd.Eliminar();

        Console.WriteLine($"Hay {cd.NumeroCanciones} canciones");

        cd.Agregar(cancion1);
        cd.Agregar(cancion2);
        cd.Agregar(cancion3);

        Console.WriteLine($"Hay {cd.NumeroCanciones}  canciones");

        Cancion primeraCancion = cd.ObtenerCancion(0);

        Console.WriteLine($"Titulo: {primeraCancion.Titulo}, Autor: {primeraCancion.Autor}");
    }
}