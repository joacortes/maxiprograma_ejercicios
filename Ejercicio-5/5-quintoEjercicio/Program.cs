using System;

namespace _5_quintoEjercicio
{
    class Program
    {
        // Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
        static void Main(string[] args)
        {
            int n, mayorPares = 0, mayorImpares = 0; 
            bool flagPar = false, flagImpar = false;
            for(int i = 0; i < 20; i++){
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                
                if(n % 2 == 0){
                    if(flagPar == false){
                        mayorPares = n;
                        flagPar = true;
                    }
                    else if(n > mayorPares){
                        mayorPares = n;
                    }
                }else{
                    if(flagImpar == false){
                        mayorImpares = n;
                        flagImpar = true;
                    }
                    else if(n > mayorImpares){
                        mayorImpares = n;
                    }
                }
            }

            Console.WriteLine("El número par mayor es: {0}\nEl número impar mayor es: {1}", mayorPares, mayorImpares);
        }
    }
}
