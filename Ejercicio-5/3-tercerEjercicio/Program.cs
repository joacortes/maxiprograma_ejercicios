using System;

namespace _3_tercerEjercicio
{
    class Program
    {
        // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
        static void Main(string[] args)
        {
            double edad, promedio, contador = 0, acumulador = 0; 
            for(int i = 0; i < 20; i++){
                Console.Write("Ingrese una edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18){
                    contador++;
                    acumulador += edad;
                }

            }
            promedio = acumulador / contador;
            Console.WriteLine("{0} / {1}: {2}", acumulador, contador, promedio.ToString("00.00"));
        }
    }
}
