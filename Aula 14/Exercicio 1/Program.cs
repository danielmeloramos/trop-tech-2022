using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            double salario = 0;
            double somaSalario = 0;
            int contador = 0;

            do
            {
                Console.WriteLine("Informe o salário: ");
                salario = Convert.ToDouble(Console.ReadLine());

                if(salario > 0) {
                    contador++;
                    somaSalario += salario;
                    //Informar outros dados
                }
            } while (salario > 0);

            //Output
            Console.WriteLine(somaSalario);
            var media = somaSalario / contador;
            Console.WriteLine("Media: " + media);
        }
    }
}
