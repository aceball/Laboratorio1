using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuestos4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3] { { 1, 2, 3 }, { 4, 0, 6 }, { 7, 0, 9 } };


            mostrarDiagonal(matriz);

            Console.WriteLine("\n");
            Console.WriteLine("\nPresione una tecla para salir.");
            Console.ReadKey();
        }
        static void mostrarDiagonal(int[,] matriz)
        {
            int[] vectDiagonal = new int[3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                vectDiagonal[i] = matriz[i, i];
            }

            Console.Write("\nDiagonal en forma desordenada:");
            for (int i = 0; i < vectDiagonal.GetLength(0); i++)
            {
                Console.Write(" " + vectDiagonal[i]);
            }

            Array.Sort(vectDiagonal);

            Console.Write("\nDiagonal en forma ordenada:");
            foreach (int item in vectDiagonal)
            {
                Console.Write(" " + item);
            }
        }
    }
}
