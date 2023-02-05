namespace Ejercicio06;

class Cancion
{
    //Atributos
    private string _titulo;
    private string _autor;

    //Propiedades
    public string Titulo { get => _titulo; }
    public string Autor { get => _autor; }

    //Constructores
    public Cancion(string titulo, string autor)
    {
        _titulo = titulo;
        _autor = autor;
    }
}
