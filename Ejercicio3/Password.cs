namespace Ejercicio03;

class Password
{
    //Constantes
    public const int LONGITUD = 8;
    //Opción 1 - Contraseña
    public const string CONTRASENA = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789";

    //Atributos
    private int _longitud;
    private string _contrasena;

    //Propiedades
    public int Longitud { get => _longitud; set => _longitud = value; }
    public string Contrasena { get => _contrasena; }

    //Constructores
    public Password(int longitud)
    {
        //Opción 1 - Contraseña
        GenerarPassword(longitud);
        //Opción 2 - Contraseña
        //_contrasena = GenerarPassword();
    }
    public Password() : this(LONGITUD) { }

    //Métodos
    public bool EsFuerte()
    {
        int lower = 0;
        int upper = 0;
        int digit = 0;

        for (int i = 0; i < _contrasena.Length; i++)
        {
            if (char.IsLower(_contrasena[i])) lower++;
            else if (char.IsUpper(_contrasena[i])) upper++;
            else if (char.IsDigit(_contrasena[i])) digit++;
        }

        return upper > 2 && lower > 1 && digit > 5;
    }

    //Opción 1 - Contraseña
    private string GenerarPassword(int longitud)
    {
        Random random = new Random();

        for (int i = 0; i < longitud; i++)
        {
            _contrasena += CONTRASENA[random.Next(CONTRASENA.Length)];
        }
        return _contrasena;
    }

    //Opción 2 - Contraseña
    /*private string GenerarPassword()
    {
        StringBuilder stringBuilder = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < longitud; i++)
        {
            stringBuilder.Append((char)random.Next('0', 'z'));
        }

        return stringBuilder.ToString();
    }*/
}
