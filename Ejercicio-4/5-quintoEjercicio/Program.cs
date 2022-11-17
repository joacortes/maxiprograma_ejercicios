using System;

namespace _5_quintoEjercicio
{
    class Program
    {
        // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
        static void Main(string[] args)
        {
            int n, n1, n2, n3;

            Console.WriteLine("Ingresar un numero: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar un numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar un numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar un numero: ");
            n3 = int.Parse(Console.ReadLine());

            if(n > n1 && n1 > n2 && n2 > n3){
                Console.WriteLine("Esta ordenado de forma decreciente");
            }else{
                Console.WriteLine("No esta ordenado");
            }
        }
    }
}
