namespace Ejercicio07;

interface IEntregable : IComparable
{
    void Entregar();
    void Devolver();

    bool EsEntregado();
}