namespace Ejercicio06;

class CompactDisc
{
    //Atributos
    private Cancion[] _canciones; //Coge de la Clase canciones las instancias y las mete en un array
                                  //para poder operar con ellas
    private int _contador;

    //Propiedades
    public int NumeroCanciones => _contador; //devuelve el valor de contador

    //Constructores
    public CompactDisc(int tamano)
    {
        _canciones = new Cancion[tamano];
        _contador = 0;
    }

    //Métodos
    public Cancion ObtenerCancion(int numero) => _canciones[numero];

    public void Agregar(Cancion cancion)
    {
        if (_contador >= _canciones.Length) Console.WriteLine("No se puede Agregar, se ha completado");
        else
        {
            _canciones[_contador] = cancion;
            _contador++;
        }
    }

    public void Eliminar()
    {
        if (_contador == 0) Console.WriteLine("No hay canciones");
        else _contador--; //se resta y al resta el contador se elimina la posición de la canción, de forma
                          //lógica es como eliminarla auque no se elimine, cuando se vuelva a agregar la
                          //sustituye y es cuando se reemplaza realmente
    }
}
