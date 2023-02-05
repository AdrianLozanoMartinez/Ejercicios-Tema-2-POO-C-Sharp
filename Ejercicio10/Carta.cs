using System.Text;

namespace Ejercicio10;

public class Carta<T> where T : Enum
{
    //Atributos
    private int _numero;
    private T _palo;

    //Propiedades
    public int Numero { get => _numero; }
    public T Palo { get => _palo; }

    //Constructores
    public Carta(int numero, T palo)
    {
        _numero = numero;
        _palo = palo;
    }

    //Métodos
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        string nombre = "";

        switch (_numero)
        {
            case 1:
                nombre = "As";
                break;
            case 10:
                if (_palo is PalosBarajaEspanola)
                    nombre = "Sota";
                else
                    nombre = _numero.ToString();
                break;
            case 11:
                if (_palo is PalosBarajaEspanola)
                    nombre = "Caballo";
                else if (_palo is PalosBarajaFrancesa)
                    nombre = "Jota";
                break;
            case 12:
                if (_palo is PalosBarajaEspanola)
                    nombre = "Rey";
                else if (_palo is PalosBarajaFrancesa)
                    nombre = "Reina";
                break;
            case 13:
                if (_palo is PalosBarajaFrancesa)
                    nombre = "Rey";
                else
                    nombre = _numero.ToString();
                break;
            default:
                nombre = _numero.ToString();
                break;
        }

        builder.AppendLine($"Número/Nombre: {nombre} de {_palo}");

        return builder.ToString();
    }

}
