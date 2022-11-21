using System;

namespace _3_tercerEjercicios
{
    class Program
    {
        // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

        static void Main(string[] args)
        {
            int num, contPrimos = 0, promedio, acumulador = 0;
            
            num = int.Parse(Console.ReadLine());

            while(num != 0){
                if(primo(num)){
                    contPrimos++;
                    acumulador += num;
                }
                    
                num = int.Parse(Console.ReadLine());
            }

            promedio = acumulador / contPrimos;

            Console.WriteLine("El promedio de primos es de " + promedio);
        }

        static bool primo(int a){
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
