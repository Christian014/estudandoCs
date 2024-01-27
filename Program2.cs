using System;


    class NumPrimo{
         static void Main(string[] args){

            Console.WriteLine("App de Numeros Primos");

            string num = Console.ReadLine();
            int resultado = Convert.ToInt32(num);

            if(resultado > 1){
                for(int i = 2; i <= Math.Sqrt(resultado); i++){
                    if(resultado % i == 0){
                        Console.WriteLine("Numero não é primo");
                    }                    
                }
            }else
            {
                
            }
            Console.WriteLine("Numero é primo");
        }
    }
