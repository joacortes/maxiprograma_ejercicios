using System;

namespace _3_tercerEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            
            int numero = 1, contListas;

            
            while(numero >= 0){
                contListas = 0;
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
                while(numero > 0){
                    contListas++;

                    Console.Write("Ingrese un número: ");
                    numero = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("En la lista se ingrearon un total de {0} numeros", contListas);
            }
        }
    }
}
