using System;

namespace _1_primerEjercicio
{
    class Program
    {
        // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int max;

            for(int i = 0; i < num.Length; i++){
                Console.Write("Ingrese un número: ");
                num[i] = int.Parse(Console.ReadLine()); 
            }

            max = num[0];

            for(int i = 0; i < num.Length; i++){
                if(num[i] > max)
                    max = num[i];
            }

            Console.WriteLine("El número mayor del array es: " + max);
        }
    }
}
