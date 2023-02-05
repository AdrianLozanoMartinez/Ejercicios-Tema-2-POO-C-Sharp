using System.Text;

namespace Ejercicio07;

class VideoJuego
{
    //Constantes
    private const int HORAS = 10;

    //Atributos
    private string _titulo;
    private int _horas;
    private bool _entregado;
    private string _genero;
    private string _compania;

    //Propiedades
    public string Titulo { get => _titulo; set => _titulo = value; }
    public int Horas { get => _horas; set => _horas = value; }
    public string Genero { get => _genero; set => _genero = value; }
    public string Compania { get => _compania; set => _compania = value; }

    //Constructores
    public VideoJuego(string titulo, int horas, string genero, string compania)
    {
        Titulo = titulo;
        Horas = horas;
        Genero = genero;
        Compania = compania;
        _entregado = false;
    }
    public VideoJuego(string titulo, int horas) : this(titulo, horas, "", "") { }
    public VideoJuego() : this(string.Empty, HORAS) { }

    //Métodos 
    public override string ToString()
    {
        //Opción 1
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Título: {Titulo}, Horas: {Horas}, Tipo: {Genero}, Compañía: {Compania}, Entregado: {_entregado}");
        return builder.ToString();

        //Opción 2
        //return $"Título: {Titulo}, Horas: {Horas}, Genero: {Genero}, Compañía: {Compania}, Entregado: {_entregado}";
    }

    public void Entregar()
    {
        _entregado = true;
    }

    public void Devolver()
    {
        _entregado = false;
    }

    public bool EsEntregado() => _entregado;

    public int CompareTo(object obj)
    {
        int estado = 1;

        VideoJuego videoJuego = obj as VideoJuego;

        if (videoJuego != null)
        {
            estado = Horas.CompareTo(videoJuego.Horas);
        }

        return estado;
    }
    /*
    "113A".CompareTo."113C"
    Se compara el 1º sobre el 2º. Es decir, El 1º es menor/mayor/igual que el 2º. En este caso es menor, 
    ya que al comparar A con C, A es menor según el codigo ASCII.

    Cuando sea mayor/menor se para de comparar, por eso aunque tenga más letras una parte da igual, sino avanza 
    cuando son igual

    Diferencia Equals con CompareTo
    -Equals: Si son exactamente igual
    -CompareTo: mayor/menor/igual, devuelve un número mayor que cero(si es mayor el 1º), 
    menor que cero(si es menor el 1º) o 0(si 1º y 2º son iguales).
     */

}
