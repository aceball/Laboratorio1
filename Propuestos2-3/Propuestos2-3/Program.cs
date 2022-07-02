using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuestos2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nroVendedores = 0, importeVenta = 0, vendedorMVentas = 0, cantVentas = 0, importeVentaMayor = 0, i = 0, salir = 0, vendedor1 = 0, vendedor2 = 0, vendedor3 = 0;
            string dia = "", diaMayorVenta = "";

            while (i == 0)
            {
                Console.WriteLine("Ingrese el numero de vendedor");
                nroVendedores = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el importe de la venta");
                importeVenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el dia de la venta");
                dia = Console.ReadLine();

                if (nroVendedores == 1)
                {
                    vendedor1 = vendedor1 + 1;
                }
                else if (nroVendedores == 2)
                {
                    vendedor2 = vendedor2 + 1;
                }
                else
                {
                    vendedor3 = vendedor3 + 1;
                }

                if (vendedor1 >= vendedorMVentas)
                {
                    vendedorMVentas = 1;
                    cantVentas = vendedor1;
                    if (vendedor2 >= vendedor1)
                    {
                        vendedorMVentas = 2;
                        cantVentas = vendedor2;
                        if (vendedor2 >= vendedor3)
                        {
                            vendedorMVentas = 3;
                            cantVentas = vendedor3;
                        }
                    }
                }
                if (importeVentaMayor < importeVenta)
                {
                    importeVentaMayor = importeVenta;
                    diaMayorVenta = dia;
                }

                Console.WriteLine("¿Desea seguir ingresando ventas?(1 = si, 0 = no) ");
                salir = int.Parse(Console.ReadLine());
                if (salir == 0)
                {
                    i = i - 1;
                }
            }
            Console.WriteLine("El vendedor que realizo mas ventas fue:  " + vendedorMVentas, ".La cantidad de ventas fue:  ", +cantVentas);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("El dia que se realizo la venta de mayor importe fue: " + diaMayorVenta, ". El importe fue de:  " + importeVentaMayor);
        }
    }
}
