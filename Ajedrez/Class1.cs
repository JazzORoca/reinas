using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Tablero
    {
        private int[,] tablero = new int[8, 8];

        // Método principal para resolver el problema de las 8 reinas
        public bool ColocarReinas(int fila)
        {
            // Si hemos colocado reinas en todas las filas, la solución es correcta
            if (fila >= 8)
                return true;

            // Intenta colocar una reina en cada columna de la fila actual
            for (int columna = 0; columna < 8; columna++)
            {
                if (EsPosicionSegura(fila, columna))
                {
                    tablero[fila, columna] = 1; // Coloca la reina

                    // Llama recursivamente para colocar la siguiente reina
                    if (ColocarReinas(fila + 1))
                        return true;

                    // Si no se encuentra una solución, quita la reina y prueba la siguiente columna
                    tablero[fila, columna] = 0;
                }
            }

            return false; // No se encontró una posición válida para esta fila
        }

        // Método para verificar si es seguro colocar una reina en la posición dada
        private bool EsPosicionSegura(int fila, int columna)
        {
            // Verifica la misma columna en las filas anteriores
            for (int i = 0; i < fila; i++)
                if (tablero[i, columna] == 1)
                    return false;

            // Verifica la diagonal superior izquierda
            for (int i = fila, j = columna; i >= 0 && j >= 0; i--, j--)
                if (tablero[i, j] == 1)
                    return false;

            // Verifica la diagonal superior derecha
            for (int i = fila, j = columna; i >= 0 && j < 8; i--, j++)
                if (tablero[i, j] == 1)
                    return false;

            return true; // La posición es segura
        }

        // Método para imprimir el tablero con la solución encontrada
        public void ImprimirTablero()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tablero[i, j] == 1)
                        Console.Write("Q ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
        }
    }
    }
