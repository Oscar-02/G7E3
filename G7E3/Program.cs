using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G7E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double res = 0;
            try
            {
                Console.WriteLine("Ingrese el valor del primer numero...");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del segundo numero...");
                num2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error en el formato ingresado. SOLO INGRESE VALORES NUMERICOS");
                Console.WriteLine("El programa se cerrara al pulsar cualquier tecla...");
                Console.ReadKey();
                return;
            }
            if (num2 <= num1)
            {
                Console.WriteLine("El segundo numero ingresado (" + num2 + ") no puede ser menor o igual al primer numero (" + num1 + ")");
                Console.WriteLine("EL PROGRAMA SE CERRARA AL PULSAR UNA TECLA...");
                return;
            }
            else
            {
                while (num1 != num2 + 1)
                {
                    res = num1 % 2;
                    if (res == 0)
                    {
                        Console.WriteLine(num1);
                    }
                    num1++;
                }
                Console.ReadKey();
            }
        }
    }
}
