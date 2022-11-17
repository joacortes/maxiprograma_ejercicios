using System;

namespace tercerEjercicio
{
    // 2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;

            Console.Write("Ingrese un número para elevarlo al cubo: ");
            n = int.Parse(Console.ReadLine());

            r = n * n * n;
            Console.WriteLine("{0} ^ 3 = {1}", n, r);
        }
    }
}
