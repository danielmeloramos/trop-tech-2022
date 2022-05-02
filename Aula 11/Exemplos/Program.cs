using System;

namespace Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo 1
            /*
             var nomeVariavel = 10;
             var nomeVariavelSemDefinicao = 10;

             var logico = false;
             var tituloDaAula = "Variaveis em C#";

             tituloDaAula = "Constantes em C#"; */

             // Exemplo 2
             //const int algumaConstante = 10;

             // Exemplo 3
             /*string tituloDaAula = "titulo da aula";
             char letra = 'a';

             string umaPalavra;
             umaPalavra = "Teste";*/

            //Exemplo 4
            /**var primeiraPalavra = "Boas";
             var segundaPalavra = "Vindas";

             const char hifen = '-';

             Console.WriteLine(primeiraPalavra + hifen + segundaPalavra); **/

             //Exemplo 5
             /*var primeiraPalavra = "Boas";
             var segundaPalavra = "Vindas";
             const char hifen = '-';
             Console.WriteLine($"{primeiraPalavra}{hifen}{segundaPalavra}"); */

             //Exemplo 6
             /*var primeiraPalavra = "Boas";
             var segundaPalavra = "Vindas";
             const char hifen = '-';

             var frase = string.Concat(primeiraPalavra, hifen, segundaPalavra);
             Console.WriteLine(frase);*/

             //Exemplo 7
             Console.WriteLine("#### Sejam Bem Vindos! ####");
             Console.WriteLine("\n");

             Console.Write("Digite o seu nome: ");
             var nomeDoCandidato = Console.ReadLine();

             Console.Write("Digite o estado que você reside: ");
             var estadoDeOrigem = Console.ReadLine();

            Console.Write("Digite sua data de nascimento: ");
            var dataDeNascimento = Console.ReadLine();

            Console.WriteLine(nomeDoCandidato);
        }
    }
}
