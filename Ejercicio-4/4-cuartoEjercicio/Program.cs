using System;

namespace _4_cuartoEjercicio
{
    class Program
    {
        // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
        static void Main(string[] args)
        {
            int n, n1, n2;

            Console.Write("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            n2 = int.Parse(Console.ReadLine());

            if(n + n1 > n1 * n2){
                Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo y el tercero");
            }
            
        }
    }
}
