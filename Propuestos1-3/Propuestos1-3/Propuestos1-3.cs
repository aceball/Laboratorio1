using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuestos1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            int numVendedor = 0;
            string dia = "";
            float importe = 0f;

            int cantVend1 = 0;
            float mayorVentaVend1 = 0f;
            string diaMayorVentaVend1 = "";
            string diaSemanaVend1 = "";

            int cantVend2 = 0;
            float mayorVentaVend2 = 0f;
            string diaMayorVentaVend2 = "";
            string diaSemanaVend2 = "";

            for (i = 1; i <= 7; i++)
            {
                Console.WriteLine("->Ingrese el Nro.vendedor");
                numVendedor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("->Ingrese el día de la venta");
                dia = Console.ReadLine();

                Console.WriteLine("->Ingrese el importe de la venta");
                importe = Convert.ToInt32(Console.ReadLine());

                if (numVendedor == 1)
                {
                    cantVend1++;

                    if (mayorVentaVend1 < importe)
                    {
                        mayorVentaVend1 = importe;
                        diaMayorVentaVend1 = dia;

                    }
                }
                if (numVendedor == 1)
                {
                    cantVend2++;

                    if (mayorVentaVend2 < importe)
                    {
                        mayorVentaVend2 = importe;
                        diaMayorVentaVend2 = dia;

                    }
                }
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Nro.de vendedor: 1");
            Console.WriteLine($"Cantidad de ventas: {cantVend1}");
            Console.WriteLine($"Día de las mayores ventas : {diaSemanaVend1}");
            Console.WriteLine($"Importe de mayor venta: $ {mayorVentaVend1}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Nro.de vendedor: 2");
            Console.WriteLine($"Cantidad de ventas: {cantVend1}");
            Console.WriteLine($"Día de las mayores ventas : {diaSemanaVend2}");
            Console.WriteLine($"Importe de mayor venta: $ {mayorVentaVend2}");
            Console.WriteLine("----------------------------------------------");
            if (cantVend1 > cantVend2)
            {
                Console.WriteLine($"El 1° vendedor fue el que mas vendio con: ${cantVend1}");
            }
            else
            {
                Console.WriteLine($"El 2° vendedor fue el que mas vendio con: ${cantVend2}");
            }
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("\nPresione una tecla para terminar.");
            Console.ReadKey();
        }
    }
}
