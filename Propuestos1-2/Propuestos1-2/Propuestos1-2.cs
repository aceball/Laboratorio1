using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuestos1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte salir = 0, nota = 0, materia = 0;
            int i = 0, legajo = 0, cantMat = 0, cantFis = 0, aproMate = 0, aproFis = 0, notaMate = 0, notaFis = 0;
            float promMat = 0f, proFis = 0f;

            while (salir == 0)
            {
                Console.WriteLine($"Ingrese el legajo del {i + 1}° Alumno");
                legajo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ingrese la nota del {i + 1}° Alumno");
                nota = byte.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese 1 para matematica o 2 para física del {i + 1}° Alumno");
                materia = byte.Parse(Console.ReadLine());

                if (materia == 1)
                {
                    cantMat++;

                    if (nota >= 7)
                    {
                        aproMate++;
                    }

                    notaMate += nota;

                }
                else
                {
                    cantFis++;

                    if (nota >= 7)
                    {
                        aproFis++;
                    }

                    notaFis += nota;

                }

                Console.WriteLine("\nPresione 1 para salir, 0 para continuar.");
                salir = byte.Parse(Console.ReadLine());
            }

            promMat = cantMat / notaMate;
            proFis = cantFis / notaFis;

            Console.WriteLine($"Materia: Matemática");
            Console.WriteLine($"Cantidad de alumnos: {cantMat}");
            Console.WriteLine($"Cantidad de alumnos aprobados: {aproMate}");
            Console.WriteLine($"Cantidad de alumnos reprobados: {cantMat - aproMate}");
            Console.WriteLine($"Promedio general obtenido: {promMat}");
            Console.WriteLine("\n");
            Console.WriteLine($"Materia: Física");
            Console.WriteLine($"Cantidad de alumnos: {cantFis}");
            Console.WriteLine($"Cantidad de alumnos aprobados: {aproFis}");
            Console.WriteLine($"Cantidad de alumnos reprobados: {cantFis - aproFis}");
            Console.WriteLine($"Promedio general obtenido: {proFis}");

            Console.WriteLine("\nPresione una tecla para terminar.");
            Console.ReadKey();
        }
    }
}
