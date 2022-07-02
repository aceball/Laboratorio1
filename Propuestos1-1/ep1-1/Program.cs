using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ep1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte salir = 0, mozos = 0, plato = 0;
            int mozo1 = 0, mozo2 = 0, cantPlatos = 0, plato1 = 0, plato2 = 0, plato3 = 0;

            while (salir == 0)
            {
                cantPlatos += 1;

                Console.WriteLine("Igrese el numero de mozo:");
                mozos = byte.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el n°: 1 para Milanesas con papas fritas, 2 para Pizzas, 3 para Plato Especial. el numero de plato que llevara el mozo:");
                plato = byte.Parse(Console.ReadLine());

                if (mozos == 1)
                {
                    mozo1++;
                }
                else
                {
                    mozo2++;
                }

                if (plato == 1)
                {
                    plato1++;
                }
                else if (plato == 2)
                {
                    plato2++;
                }
                else
                {
                    plato3++;
                }

                Console.WriteLine("\nPresione 1 para salir, 0 para continuar.");
                salir = byte.Parse(Console.ReadLine());
            }

            if (mozo1 > mozo2)
            {
                Console.WriteLine("\nEl mozo que más platos sirvió es: 1");
            }
            else
            {
                Console.WriteLine("\nEl mozo que más platos sirvió es: 2");
            }

            Console.WriteLine($"Cantidad de platos servidos: {cantPlatos}");
            Console.WriteLine($"Cantidad del Plato nº 1: {plato1}");
            Console.WriteLine($"Cantidad del Plato nº 2: {plato2}");
            Console.WriteLine($"Cantidad del Plato nº 3: {plato3}");

            Console.WriteLine("\nPresione una tecla para terminar.");
            Console.ReadKey();
        }
    }
}
