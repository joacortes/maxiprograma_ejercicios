using System;

namespace _1_primerEjercicio
{
    class Program
    {
        // 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
        static void Main(string[] args)
        {
            int n, cont, primos = 0;
            

            

            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese el número {0}: ", i);
                n = int.Parse(Console.ReadLine());
                cont = 0;
                for(int j = 1; j < n; j++){
                    if(n % j == 0){
                        cont++;
                    }
                }

                if(cont < 2){
                    primos++;
                }

                
            }
            
            Console.WriteLine("Hay {0} numeros primos", primos);

        }
    }
}
