using System;

namespace segundoEjercicio
{
// 1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese el número 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine("{0} + {1} = {2}", n1, n2, resultado);
        }
    }
}
