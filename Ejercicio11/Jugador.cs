namespace Ejercicio11;

class Jugador
{
    //Constantes
    private const int MAXIMA = 5;

    //Atributos
    private Vector3 posicion;
    private bool estarVivo;

    //Propiedades
    public bool EstarVivo => estarVivo;

    //Constructores
    public Jugador(Vector3 posicionInicial)
    {
        posicion = posicionInicial;
        this.estarVivo = true;
    }
    public Jugador() : this(new Vector3()) { }

    //Métodos
    public void Mover(Vector3 unidadesDesplaza)
    {
        posicion = posicion.Sumar(unidadesDesplaza);
    }

    public void Morir()
    {
        estarVivo = false;
    }

    public void Matar(Jugador jugador)
    {
        if (posicion.Distancia(jugador.posicion) < MAXIMA) jugador.Morir();
    }
}

