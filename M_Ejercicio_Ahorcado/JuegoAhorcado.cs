using System.Drawing;

namespace M_Ejercicio_Ahorcado;

class JuegoAhorcado
{
    public const int MAXIMO = 10;
    public const int MINIMO = 4;

    private const int TAMANO = 20;
    private const int OCHENTAPORCIEN = 80 * TAMANO / 100;
    public const string ABC = "abcdefghijklmnopqrstuvwxyz";

    private string _secreta;
    private int _intentos;
    private string _comprobar;
    private int _contador;
    private string[] _palabraGuardada;

    private string[] _palabra = new string[] //Palabras entre 4 a 10 letras
    {
        "huevo","patata","zanahoria","cacahuete","pera","manzana","banana","platano",
        "pizza","queso","leche","galleta","turron","ensalada","gamba","cebolla",
        "agua","maiz","pimiento","brocoli"
    };

    public JuegoAhorcado(int tamano, int intentos) 
    {
        _palabraGuardada = _palabra; //Llenamos la auxiliar con todas las letras, para luego usarla y quitar y con la anterior recuperar todas
        _contador = _palabra.Length;
        CogerPalabraSecreta(tamano); //Comenzamos el juego BUSCANDO la palabra aleatoria
        _intentos = intentos;
    }

    public void CogerPalabraSecreta(int tamano) //Buscamos palabra aleatoria
    {
        try
        {
            Random random = new Random();

            if (tamano >= MINIMO && tamano <= MAXIMO) //Comparamos que esté entre el mínimo y máximo
            {
                _comprobar = _palabra[random.Next(0, 20)]; //Metemos aleatoriamente la palabra

                if(_comprobar.Length >= MINIMO && _comprobar.Length <= MAXIMO)
                {
                    _secreta = _comprobar;
                    Console.WriteLine($"Palabra secreta: {_secreta}\n");
                    Probar();
                }


                //ComprobarCantidad(); //Comprobamos si esa palabra está en el listado
            }
            else
            {
                throw new Exception("La palabra no tiene el tamaño especificado");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Probar()
    {
        Random random = new Random();
        char _elegida;
        int cont = 0;
        bool estado = false;
        string repetida = "";
        string repetida2 = "";
        string container = "";

        do
        {
            _elegida = ABC[random.Next(0, 26)];

            //ESTO COMENTADO PODRÍA ELIMINAR LOS REPETIDOS COMO EN EL AHORCADO QUE HICE

            /* for (int i = 0; i < _secreta.Length; i++)  //Palabra por acertar
            {
                if (!repetida.Contains(_secreta[i]))     //Para que no se repita las palabras
                {
                    repetida += _secreta[i];             //Metemos el carácter en match2 sino se repite
                }
            }

            for (int i = 0; i < container.Length; i++)  //Palabra por acertar
            {
                if (!repetida2.Contains(container[i]))     //Para que no se repita las palabras
                {
                    repetida2 += container[i];             //Metemos el carácter en match2 sino se repite
                }
            }*/


            if (_secreta.Contains(_elegida) && !repetida.Contains(_elegida))
            {
                repetida += _elegida;
                cont++;
                Console.Write(_elegida + " ");

                if (_secreta.Length == repetida.Length) //Esta parte falla porque hay que eliminar lo repetido y contar la cantidad total
                {
                    Console.WriteLine($"La palabra era: {_secreta}");
                    estado = true;
                }
            }
            else
            {
                _intentos--;
                estado = false;
            }



            

        } while (estado == false || _intentos != 0);

        ComprobarCantidad();
    }

    public void ComprobarCantidad() //Comprobar que la palabra esté en la lista
    {
        if (_palabraGuardada.Length < OCHENTAPORCIEN) //Menor del 80%
        {
            _palabraGuardada = _palabra; //Metemos de nuevo todas las palabras
            Eliminar();
        }
        else
        {
            //Console.WriteLine(_palabra.Length); //20
            //Console.WriteLine(_contador); //20
            Eliminar();
            
        }
    }

   


    public void Eliminar()
    {
        int index = -1; //Ponemos -1 porque el i empieza con 0 y de ese modo se para aunque coja la 1º palabra

        for (int i = 0; i < _contador && index < 0; i++) //Buscamos hasta el contador que en principio es la longitud del array principal y mientras que el index sea menor que -1
        {
            if (_secreta.Equals(_palabraGuardada[i])) //Si es igual la palabra aleatoria que una de la lista guardada 
            {
                index = i; //guardamos la posición en index
            }
        }

        if (index >= 0) //Si index tiene contenido superior a -1, es decir ha encontrado palabra
        {
            for (int i = index; i < _contador - 1; i++) //Recorremos desde esa posición encontrada hasta el final del contador, contador es la extensión del array 
            {
                _palabraGuardada[i] = _palabraGuardada[i + 1]; //Pasamos el siguiente a la anterior para mover toda la lista y reemplazar dicha palabra y de ese modo borrar
            }
            _contador--; //Eliminamos un hueco del contador para que muestre un artículo menos y de ese modo completar la eliminación
        }

        Mostrar();
    }

    

    public void Mostrar()
    {
        for (int i = 0; i < _contador; i++)
        {
            Console.WriteLine($"{_palabraGuardada[i]}");
        }
    }
}
