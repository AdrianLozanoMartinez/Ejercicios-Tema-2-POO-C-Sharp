namespace Ejercicio07;

class Program
{
    static void Main()
    {
        /*Serie[] serie = new Serie[5]
            {
              new Serie(),
              new Serie("The walking dead", "Alguien"),
              new Serie("Resident evil", 2, Serie.Genero.Horror, "No fui yo"),
              new Serie(),
              new Serie("Bola de dan", 1, Serie.Genero.Infantil, "Autor desconocido")
            };

            VideoJuego[] videoJuego = new VideoJuego[5]
            {
                new VideoJuego(),
                new VideoJuego("Final fantasy", 36),
                new VideoJuego("Resident evil", 20, VideoJuego.Genero.Horror, "Camconp"),
                new VideoJuego(),
                new VideoJuego("Silent hill", 15)
            };*/

        Serie[] serie = new Serie[5];
        VideoJuego[] videoJuego = new VideoJuego[5];

        serie[0] = new Serie();
        serie[1] = new Serie("Juego de tronos", "George R. R. Martin ");
        serie[2] = new Serie("Los Simpsons", 25, "Dibujos", "Matt Groening");
        serie[3] = new Serie("Padre de familia", 12, "Dibujos", "Seth MacFarlane");
        serie[4] = new Serie("Breaking Bad", 5, "Acción", "Vince Gilligan");

        videoJuego[0] = new VideoJuego();
        videoJuego[1] = new VideoJuego("Assasin creed 2", 30, "Medieval", "EA");
        videoJuego[2] = new VideoJuego("God of war 3", 40);
        videoJuego[3] = new VideoJuego("Super Mario 3DS", 30, "Retro", "Nintendo");
        videoJuego[4] = new VideoJuego("Final fantasy X", 200, "Rol", "Square Enix");

        serie[4].Entregar();
        serie[2].Entregar();
        videoJuego[0].Entregar();
        videoJuego[2].Entregar();
        videoJuego[4].Entregar();

        int contSerie = 0;
        for (int i = 0; i < serie.Length; i++)
        {
            if (serie[i].EsEntregado()) contSerie++;
        }

        int contVideojuego = 0;
        for (int i = 0; i < videoJuego.Length; i++)
        {
            if (videoJuego[i].EsEntregado()) contVideojuego++;
        }

        Console.WriteLine($"Serie entregadas: {contSerie}\nJuegos entregados: {contVideojuego}");

        Serie serieMayor = serie[0];
        VideoJuego videoJuegoMayor = videoJuego[0];

        for (int i = 1; i < serie.Length; i++)
        {
            if (serie[i].CompareTo(serieMayor) > 0) serieMayor = serie[i];

            if (videoJuego[i].CompareTo(videoJuegoMayor) > 0) videoJuegoMayor = videoJuego[i];
        }

        Console.WriteLine(serieMayor);
        Console.WriteLine(videoJuegoMayor);
    }
}