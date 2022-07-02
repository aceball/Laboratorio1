using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propuestos3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cantidad = 0;
            List<double> Numero = new List<double>();
            string Control = "NO";
            while (Control == "NO")
            {
                Console.Clear();
                System.Console.Write("Ingrese un Numero:");
                Numero.Add(double.Parse(Console.ReadLine()));
                Cantidad++;
                Control = Pregunta();
            }

            Calcular(Numero);
        }
        static void Calcular(List<Double> Num)
        {
            int par = 0, inpar = 0, primo = 0, noprimo = 0, posMayor = 0, posMenor = 0;
            double mayor = 0, menor = 10000000000000000, suma = 0;

            for (int i = 0; i < Num.Count; i++)
            {
                if ((Num[i] % 2) == 0)
                {
                    par++;
                }
                else
                {
                    inpar++;
                }
                if (EsPrimo(Num[i]))
                {

                    primo++;
                }
                else
                {
                    noprimo++;

                }
                if (Num[i] >= mayor)
                {
                    mayor = Num[i];
                    posMayor = i;
                }
                if (Num[i] < menor)
                {
                    menor = Num[i];
                    posMenor = i;
                }

                suma = suma + Num[i];

            }
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Cantidad de Numeros Ingresados: {Num.Count}.");
            Console.WriteLine($"La cantidad de Numeros Pares es: {par}.");
            Console.WriteLine($"La cantidad de Numeros Impares es: {inpar}.");
            Console.WriteLine($"La cantidad de Numeros Primos es: {primo}.");
            Console.WriteLine($"La cantidad de Numeros No Primos es: {noprimo}.");
            Console.WriteLine($"El Mayor numero regristado es: {mayor} y su orden de carga es: {posMayor}.");
            Console.WriteLine($"El Menor numero registrado es: {menor} y su orden de carga es: {posMenor}.");
            Console.WriteLine($"El Promedio de todos los numeros ingresados es: {Math.Round(suma / Num.Count, 2)}.");
            Console.WriteLine("---------------------------------------------------");

        }
        static bool EsPrimo(double numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {

                    return false;
                }
            }
            return true;
        }
        static string Pregunta()
        {
            string respuesta = "";
            Console.Write("Salir: SI/NO: ");
            respuesta = Console.ReadLine();

            respuesta = respuesta.ToUpper();

            return respuesta;

        }
    }
}
