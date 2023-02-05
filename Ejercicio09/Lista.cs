using System.Text;

namespace Ejercicio09;

class Lista<T>
{
    //Constantes
    private const int SIZE = 10;

    //Atributos
    private T[] _items;
    private int _nextPosition;

    //Propiedades
    public int Capacity { get => _items.Length; }
    public int Count { get => _nextPosition; }

    //Constructores
    public Lista(int size)
    {
        _items = new T[size]; //Metemos el tamaño del array por parámetro en una instancia
        _nextPosition = 0; //Inicializamos a 0 para meterlo la información en la 1º posición
    }
    public Lista() : this(SIZE) { }

    //Métodos
    public T Get(int index)
    {
        return _items[index]; //Mostramos el item solicitado a través de la posición
    }

    public void Add(T item)
    {
        if (_nextPosition >= Capacity) //Si la lista está llena
        {
            T[] newItems = new T[Capacity * 2]; //Creamos un array donde ampliamos el espacio *2

            for (int i = 0; i < Capacity; i++) 
            {
                newItems[i] = _items[i]; //Metemos el contenido del anterior intem en el nuevo array
            }
            _items = newItems; //Cambiamos el array por el item, para operar con item siempre
        }
        _items[_nextPosition] = item; //Metemos el nuevo parámetro/item en items en la posición 0 y
                                      //luego el que le toque
        _nextPosition++; //Ampliamos +1 la posición cada vez que añadimos un item
    }

    public void Remove(T item)
    {
        int index = -1; //Inicializamos a -1 para cuando tenga un valor 0 o más se salga del bucle,
                        //de ese modo controlamos que coja la 1º ocurrencia/coincidencia de item con items
        for (int i = 0; i < Capacity && index < 0; i++)
        {
            if (item == null && _items[i] == null || item.Equals(_items[i])) //Si son ambos nulos o coinciden
            {                                                                //Le metemos el valor de i u otro
                                                                             //para salir del bucle porque queremos 
                                                                             //la 1º oncurrencia, si quisieramos todos
                                                                             //no saldríamos del bucle
                index = i;
            }
        }

        if (index >= 0) //Al tener un valor entramos en el for para eliminar
        {
            for (int i = index; i < _nextPosition - 1; i++) //desde la posición que queremos eliminar hasta
            {                                               //un número menos de la _nextPosition ya que al
                                                            //añadir sumamos +1 por lo que no hay más números
                                                            //ahí. Sin embargo le quitamos un -1 también
                                                            //porque como sumamos una posición al items
                                                            //se saldría sino restamos..
                _items[i] = _items[i + 1]; //Si queremos borrar la posición 3, coge la posición 4
                                           //_items[i + 1] y lo metemos en 3 _items[i]
            }

            _nextPosition--; //Restamos una posición al eliminarse cada elemento
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append("[");

        for (int i = 0; i < _nextPosition; i++)
        {
            builder.Append($"{_items[i]}");

            if (i < _nextPosition - 1)
                builder.Append($", ");
        }

        builder.Append("]");

        return builder.ToString();
    }
}
