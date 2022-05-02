using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            decimal numero = Convert.ToDecimal(Console.ReadLine()); //2
            
            //var soma = numero; //2
            //soma += 2; //4

            var soma = numero + 2; //4

            Console.WriteLine(numero); 
        }
    }
}
