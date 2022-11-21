using System;

namespace _2_segundoEjercicio
{
    class Program
    {
        // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int acumulador = 0, promedio; 

            for(int i = 0; i < num.Length; i++){
                Console.Write("Ingrese un numero: ");
                num[i] = int.Parse(Console.ReadLine());
                acumulador += num[i];
            }

            promedio = acumulador / num.Length;

            Console.WriteLine("Numeros mayores al promedio: ");
            for(int i = 0; i < num.Length; i++){
                if(num[i] > promedio){
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}
