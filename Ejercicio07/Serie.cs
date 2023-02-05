using System.Text;

namespace Ejercicio07;

class Serie
{
    //Constantes
    private const int TEMPORADA = 3;

    //Atributos
    private string _titulo;
    private int _numeroTemporada;
    private bool _entregado;
    private string _genero;
    private string _creador;

    //Propiedades
    public string Titulo { get => _titulo; set => _titulo = value; }
    public int NumeroTemporada { get => _numeroTemporada; set => _numeroTemporada = value; }
    public string Genero { get => _genero; set => _genero = value; }
    public string Creador { get => _creador; set => _creador = value; }

    //Constructores
    public Serie(string titulo, int numeroTemporada, string genero, string creador)
    {
        Titulo = titulo;
        NumeroTemporada = numeroTemporada;
        Genero = genero;
        Creador = creador;
        _entregado = false;
    }
    public Serie(string titulo, string creador) : this(titulo, TEMPORADA, string.Empty, creador) { }
    public Serie() : this("", "") { }

    //Métodos 
    public override string ToString()
    {
        //Opción 1
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Título: {Titulo}, Número de temporada: {NumeroTemporada}, Tipo: {Genero}, Creador {Creador}, Entregado {_entregado}");
        return builder.ToString();

        //Opción 2
        //return $"Título: {Titulo}, Temporadas: {NumeroTemporada}, Genero: {Genero}, Creador: {Creador}, Entregado: {_entregado}";
    }

    public void Entregar()
    {
        _entregado = true;
    }

    public void Devolver()
    {
        _entregado = false;
    }

    public bool EsEntregado()
    {
        return _entregado;
    }

    public int CompareTo(object obj)
    {
        int estado = 1;

        Serie serie = obj as Serie;

        if (serie != null)
        {
            estado = NumeroTemporada.CompareTo(serie.NumeroTemporada);
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
