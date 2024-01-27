using System;

namespace Estudo1{
    class Program{
        static void Second(string[] args){
            
            
            Console.WriteLine("Digite dois valores para soma");

            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int result = Convert.ToInt32(num1)  + Convert.ToInt32(num2);

            Console.WriteLine(result);
            
        }
    }
}