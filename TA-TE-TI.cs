using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using prueba_C_;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prueba_C_
{
    internal class Program
    {
        static string[,] mapa = new string[3, 3]
        {
            { " - ", " - ", " - " },
            { " - ", " - ", " - " },
            { " - ", " - ", " - " }
        };

        static void jugador0()
        {
            Console.WriteLine("\n=====JUGADOR 0 INGRESA POSICION=====\n");
            Console.WriteLine("Ingresa la fila 0-2");
            string? filainput = Console.ReadLine();

            Console.WriteLine("Ingresa la columna 0-2");
            string? columnainput = Console.ReadLine();

            if (int.TryParse(filainput, out int fila) && int.TryParse(columnainput, out int columna))
            {
                if (fila < 0 || fila >= 3 || columna < 0 || columna >= 3)
                {
                    Console.WriteLine("Fila o columna fuera de rango");
                    return;
                }
                if (mapa[fila, columna] != " - ")
                {
                    Console.WriteLine("Esa casilla ya está ocupada. Elegí otra.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Ingresa numero.");
                return;
            }

            string x = " 0 ";

            mapa[fila, columna] = x;
            matriz();
        }

        static void jugadorx()
        {
            Console.WriteLine("\n=====JUGADOR X INGRESA POSICION=====\n");
            Console.WriteLine("Ingresa la fila 0-2");
            string? filainput = Console.ReadLine();

            Console.WriteLine("Ingresa la columna 0-2");
            string? columnainput = Console.ReadLine();

            if (int.TryParse(filainput, out int fila) && int.TryParse(columnainput, out int columna))
            {
                if (fila < 0 || fila >= 3 || columna < 0 || columna >= 3)
                {
                    Console.WriteLine("Fila o columna fuera de rango");
                    return;
                }
                if (mapa[fila, columna] != " - ")
                {
                    Console.WriteLine("Esa casilla ya está ocupada. Elegí otra.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Ingresa numero.");
                return;
            }

            string x = " x ";

            mapa[fila, columna] = x;
            matriz();
        }

        static void matriz()
        {
            string input;

            Console.WriteLine("\n  0   1   2");
            // MOSTRAR MATRIZ  
            for (int i = 0; i < 3; i++) // Fila = i
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++) // Columna = j
                {
                    Console.Write(mapa[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int turnos = 0;
            while (turnos < 1000)
            {
                matriz();
                if (turnos % 2 == 0)
                {
                    jugadorx();
                }
                else
                {
                    jugador0();
                }
                Console.Clear();
                turnos++;
            }
            Console.ReadKey();
        }
    }
}
