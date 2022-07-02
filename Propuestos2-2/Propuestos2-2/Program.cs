using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuestos2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, edad = 0, edadmayor = 0, edadmenor = 9999, ordenmenor = 0, ordenmayor = 0;
            string sexo = "", grupo = "", grupomayor = "", sexomenor = "", sexomayor = "";

            while (i <= 15)
            {
                Console.WriteLine("Ingrese el grupo al que pertenece");
                grupo = Console.ReadLine();

                Console.WriteLine("Ingrese su sexo");
                sexo = Console.ReadLine();

                Console.WriteLine("Ingrese la edad");
                edad = int.Parse(Console.ReadLine());

                if (edad < edadmenor)
                {
                    edadmenor = edad;
                    sexomenor = sexo;
                    ordenmenor = i;
                }
                if (edad > edadmayor)
                {
                    edadmayor = edad;
                    ordenmayor = i;
                    sexomayor = sexo;
                    grupomayor = grupo;
                }
                i = i + 1;
            }
            Console.WriteLine("El mayor de edad pertenece al grupo  " + grupomayor, ", tiene " + edadmayor, "años, su sexo es " + sexomayor, "y su orden de carga fue " + ordenmayor, "°");
            Console.WriteLine($"\nEl menor de edad fue cargado en el orden" + ordenmenor, ", su sexo es" + sexomenor, "y su edad es de" + edadmenor)
        }
    }
}
