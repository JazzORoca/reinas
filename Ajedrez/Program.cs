using Ajedrez;

class Program
{
    static void Main(string[] args)
    {
        Tablero tablero = new Tablero();

        if (tablero.ColocarReinas(0)) // Inicia desde la fila 0
        {
            Console.WriteLine("Solución encontrada:");
            tablero.ImprimirTablero();
        }
        else
        {
            Console.WriteLine("No se encontró ninguna solución.");
        }
    }
}
