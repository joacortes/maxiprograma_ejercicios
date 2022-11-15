using System;

namespace _5quintoEjercicio
{
    class Program
    {
        // 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
        static void Main(string[] args)
        {
            int n1, n2, n3, promedio;

            Console.WriteLine("Ingrese la nota 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 3: ");
            n3 = int.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine("El promedio del alumno es: {0}", promedio);
        }
    }
}
