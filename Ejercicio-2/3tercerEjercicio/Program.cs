using System;

namespace _3tercerEjercicio
{
    class Program
    {
        // 3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
        static void Main(string[] args)
        {
            // Ejercicio de fisica jaja.
            double distancia, velocidad, tiempo;

            Console.WriteLine("Ingrese la distancia entre las dos ciudades en KM: ");
            distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad del vehiculo: ");
            velocidad = double.Parse(Console.ReadLine());

            tiempo = distancia / velocidad;

            Console.WriteLine("El tiempo en que el vehiculo llegará de un punto a otro es de {0} horas", tiempo);
        }
    }
}
