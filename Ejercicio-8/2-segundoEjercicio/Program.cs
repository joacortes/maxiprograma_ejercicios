using System;

namespace _2_segundoEjercicio
{
    class Program
    {
        // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
        static void Main(string[] args)
        {
            int num, cont = 0;
            for(int i = 0; i < 20; i++){
                num = int.Parse(Console.ReadLine());
                if(Par(num))
                    cont++;
            }

            Console.WriteLine("Hay un total de {0} numeros pares", cont);
        }

        static byte Par(int a){
            if(a % 2 == 0)
                return 1;
            else
                return 0;
        }
    }
}
