using System;

namespace TPFinal_Cortes
{
    class Program
    {
// Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
    // a. El mayor de los números pares.
    // b. La cantidad de números impares.
    // c. El menor de los números primos.
// Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
        static void Main(string[] args)
        {
            int num, mayorPar = 0, cantImpares = 0, menorPrimos = 0;
            bool flagPar = false, flagPrimo = false;

            num = int.Parse(Console.ReadLine());

            while(num != 0){

                if(num % 2 == 0){
                    
                    if(flagPar == false){
                        mayorPar = num;
                        flagPar = true;
                    }
                    else if(num > mayorPar)
                        mayorPar = num;
                    
                }else
                    cantImpares++;

                if(esPrimo(num)){
                    if(flagPrimo == false){
                        menorPrimos = num;
                        flagPrimo = true;
                    }
                    else if(num < menorPrimos)
                        menorPrimos = num;
                }else{
                    Console.WriteLine("No es primo");
                }
                num = int.Parse(Console.ReadLine());
            }

            // A:
            Console.WriteLine("El mayor de los numeros pares: {0}", mayorPar);

            // B:
            Console.WriteLine("Cantidad de numeros impares: {0}", cantImpares);

            // C:
            Console.WriteLine("El menor de los numeros primos: {0}", menorPrimos);
        }

        static bool esPrimo(int a){
            int cont = 0;
            for(int i = 1; i < a; i++){
                if(a % i == 0)
                    cont++;
                
            }

            if(cont == 1)
                return true;
            else
                return false;
        }


    }
}
