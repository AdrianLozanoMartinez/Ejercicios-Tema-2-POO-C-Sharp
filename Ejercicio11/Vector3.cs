namespace Ejercicio11;

struct Vector3
{
    //Propiedades
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    //Constructores
    public Vector3(int x, int y, int z) 
    {
        X = x;
        Y = y;
        Z = z;
    }
    public Vector3() { X = 0; Y = 0; Z = 0; }

    //Métodos
    public Vector3 Sumar(Vector3 coordenada) => new Vector3(X + coordenada.X, Y + coordenada.Y, Z + coordenada.Z);

    public double Distancia(Vector3 coordenada)
    {
        double x2 = Math.Pow(X - coordenada.X, 2);
        double y2 = Math.Pow(Y - coordenada.Y, 2);
        double z2 = Math.Pow(Z - coordenada.Z, 2);
        return Math.Sqrt(x2 + y2 + z2);
    }
}
