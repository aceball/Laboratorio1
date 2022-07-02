using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuestos3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salir = 0, i = 1, legajo = 0, cantAlumnos = 0, mayorlegajo = 0, menorlegajo = 0;
            float nota = 0, sumNotas = 0, menPromedio = int.MaxValue, mayorPromedio = int.MinValue, promedioCurso = 0;

            while (salir == 0)
            {
                Console.WriteLine($"\nIngrese el n° de legajo del {cantAlumnos + 1}° alumno.");
                legajo = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Ingrese la {i + 1}° nota ");
                    nota = Convert.ToInt32(Console.ReadLine());

                    sumNotas = sumNotas + nota;
                }
                promedioCurso = promedioCurso + sumNotas;

                if (sumNotas > mayorPromedio)
                {
                    mayorPromedio = sumNotas / 3;
                    mayorlegajo = legajo;
                }

                if (menPromedio < sumNotas)
                {
                    menPromedio = sumNotas / 3;
                    menorlegajo = legajo;
                }

                sumNotas = 0;

                cantAlumnos++;

                Console.WriteLine("\nPresione 1 para salir, 0 para continuar.");
                salir = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(cantAlumnos);
            Console.WriteLine($"Nro.Legajo mayor promedio: {mayorlegajo}");
            Console.WriteLine($"Mayor promedio: {mayorPromedio}");
            Console.WriteLine($"Nro.Legajo menor promedio: {menorlegajo}");
            Console.WriteLine($"Menor promedio: {menPromedio}");
            Console.WriteLine($"Cantidad de alumnos: {cantAlumnos}");
            Console.WriteLine($"Promedio general del curso: {promedioCurso / cantAlumnos} ");

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
