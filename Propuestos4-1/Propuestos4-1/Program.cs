using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuestos4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3] { { 7, 5, 4 }, { 1, 1, 3 }, { 3, 5, 4 } };
            int[] vectSumFilas = new int[3], vectSumColum = new int[3];
            int sumaFilas = 0, sumaColumnas = 0;

            for (int i = 0; i < 3; i++)
            {
                sumaFilas = 0;

                for (int j = 0; j < 3; j++)
                {
                    sumaFilas += matriz[i, j];
                }

                vectSumFilas[i] = sumaFilas;
            }
            for (int j = 0; j < 3; j++)
            {
                sumaColumnas = 0;

                for (int i = 0; i < 3; i++)
                {
                    sumaColumnas += matriz[i, j];
                }

                vectSumColum[j] = sumaColumnas;
            }
            Console.Write("suma de filas:  ");
            mostrarVector(vectSumFilas);
            Console.Write("\nsuma de columnas: ");
            mostrarVector(vectSumColum);

            Console.WriteLine("\nPresione una tecla para ordenar los datos de los vectores.");
            Console.ReadKey();

            Array.Sort(vectSumFilas);
            Array.Sort(vectSumColum);

            Console.WriteLine("Datos ordenados.");
            Console.Write("\nsuma de filas: ");
            mostrarVector(vectSumFilas);
            Console.Write("\nsuma de columnas: ");
            mostrarVector(vectSumColum);

            Console.WriteLine("\nPresione una tecla para salir.");
            Console.ReadKey();
        }
        static void mostrarVector(int[] vect_a_mostrar)
        {
            foreach (int contenido in vect_a_mostrar)
            {
                Console.Write(" " + contenido);
            }
        }

    }
}
