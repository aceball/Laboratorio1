using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuestos4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamfilas = 0, tamColum = 0;

            Console.WriteLine("Ingrese cantidad de filas: ");
            tamfilas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de columnas: ");
            tamColum = Convert.ToInt32(Console.ReadLine());

            string[,] matriz = new string[tamfilas, tamColum];
            string[] vectCarga = new string[tamfilas * tamColum];

            for (int i = 0; i < tamfilas; i++)
            {
                for (int j = 0; j < tamColum; j++)
                {
                    Console.WriteLine($"Ingrese un dato para la posicion [{i},{j}]");
                    matriz[i, j] = Console.ReadLine();
                }
            }

            Console.WriteLine("\n");

            mostrarValoresMatriz(matriz);

            Console.WriteLine("\nIngrese una tecla para cambiar los valores, de filas por columnas y luego volver a mostrar la matriz.");
            Console.WriteLine("\n");
            Console.ReadKey();

            string[,] matrizInversa = cambiarLosValoresFilasPorColumnas(matriz);

            mostrarValoresMatriz(matrizInversa);

            Console.WriteLine("\nIngrese una tecla para salir..");
            Console.ReadKey();
        }
        static void mostrarValoresMatriz(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.Write("\n");
            }
        }
        static string[,] cambiarLosValoresFilasPorColumnas(string[,] matriz)
        {
            string[,] matrizInversa = new string[matriz.GetLength(1), matriz.GetLength(0)];

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    matrizInversa[i, j] = matriz[j, i];
                }
            }

            return matrizInversa;
        }
    }
}
