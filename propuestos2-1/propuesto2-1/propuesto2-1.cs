using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propuesto2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, i = 0, npares = 0, nimpares = 0, mayor = 0, imayor = 0;

            Console.WriteLine("Ingrese la cantidad de numeros que desea ingresar");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine($"La cantidad de numeros que se van a ingresar es de:  {i}");

            while ( i > 0)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                if (n > mayor)
                {
                    mayor = n;
                    imayor = i;
                }
                if (n % 2 == 0)
                {
                    npares = npares + 1;
                }
                else
                {
                    nimpares = nimpares + 1;
                }

                i = i - 1;
            }
            Console.WriteLine($"El numero mayor es:  {mayor} y su orden de carga es:  {imayor}");
            Console.WriteLine($"La cantidad de numeros pares es de:  {npares}");
            Console.WriteLine($"La cantidad de numeros impares es de:  {nimpares}");
        }
    }
}
