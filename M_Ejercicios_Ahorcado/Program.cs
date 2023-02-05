namespace M_Ejercicios_Ahorcado;
/*Un atributo de objeto con la palabra secreta elegida cada vez que se inicie el juego 
  (se cree un objeto instancia de la clase).
 * Algún mecanismo estático que permita que cada vez que se cree un objeto instancia de la 
   clase, la palabra secreta sea diferente. Cuando ya se haya "gastado" más del 80% de las
   palabras, entonces podrán volverse a usar todas de nuevo, comenzando otra vez a 
   "eliminar" palabras.
 * Un constructor que recibirá como parámetro el tamaño máximo de la palabra aleatoria que
   se va a elegir, así como el máximo número de intentos que se van a permitir para el 
   juego. Si ese tamaño máximo ya no es posible (porque se hayan gastado las palabras), 
   entonces se elegirá cualquier otra palabra disponible. Si se proporciona un valor fuera
   de los rangos posibles, se generará una excepción.
 * Un método llamado "probar", que enviará una palabra y se indicará si la letra está en la
   palabra o no (true o false). Cada vez que se llame a este método, quedará un intento 
   menos. Cuando no queden intentos, este método lanzará una excepción 
   IllegalStateException.
 * Los siguientes métodos gettter:
   getIntentosRestantes(), que devolverá cuantos intentos nos quedan aún;
   getLetrasRestantes(), que devolverá cuántas letras quedan por adivinar.
 * Un método toString que devolverá la palabra "enmascarada" donde solo se observarán las 
   letras que ya se han encontrado. Las que aún no se hayan encontrado serán caracteres del
   tipo '_'. Por ejemplo "_ A B _ C _ _ A" para "CABECERA", si ya se han encontrado las 
   letras A, B, C. También se indicarán cuántos intentos quedan disponibles.
 * Una vez dispongamos de la clase, implementar un método main() de prueba que genere un 
   número aleatorio entre 4 y 10 y cree un objeto del tipo JuegoAhorcado con ese número 
   aleatorio como tamaño máximo de palabra y con 12 intentos. El programa tendrá que 
   intentar "adivinar" la palabra a base de ir probando con letras aleatorias (sin 
   repetirse) hasta que consiga adivinar la palabra o bien se le acaben los intentos 
   disponibles. Para cada paso (cada letra aleatoria), se irá indicando por pantalla en 
   qué estado se encuentra el juego (mediante el método toString). El programa no debe 
   tener ningún tipo de intervención humana. Debe "jugar" solo.*/
class Program
{
    static void Main()
    {
        JuegoAhorcado palabra = new JuegoAhorcado();
    }
}