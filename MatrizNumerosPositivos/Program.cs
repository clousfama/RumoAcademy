using System.Xml.Schema;

namespace MatrizNumerosPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#################################################");
            Console.WriteLine("####Programa para soma de cartela de um bingo####");
            Console.WriteLine("#################################################");

            int quantidadeLinhas, quantidadeColunas;

            Console.WriteLine("Quanta linhas a sua cartela tem?");
            string? linhasInformadas = Console.ReadLine();
            quantidadeLinhas = Convert.ToInt32(linhasInformadas);

            Console.WriteLine("Quanta colunas a sua cartela tem?");
            string? colunasInformadas = Console.ReadLine();
            quantidadeColunas = Convert.ToInt32(linhasInformadas);

            var matrizNumeros = new int[quantidadeLinhas, quantidadeColunas];

            for (int contadorLinhas = 0; contadorLinhas < quantidadeLinhas; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas < quantidadeColunas; contadorColunas++)
                {
                    Console.WriteLine($"Informe o número da {contadorLinhas + 1} linha, da coluna {contadorColunas + 1}:");
                    int numeroInformado = Convert.ToInt32(Console.ReadLine());
                    matrizNumeros[contadorLinhas, contadorColunas] = numeroInformado;
                }
            }
           
            int somaNumeros = 0;
            for (int contadorLinhas = 0; contadorLinhas < quantidadeLinhas; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas < quantidadeColunas; contadorColunas++)
                {
               int numeroInformado = matrizNumeros[contadorLinhas, contadorColunas];
                    if (numeroInformado < 0)
                        continue;

                    somaNumeros = somaNumeros + numeroInformado ;
                }
            }
            Console.WriteLine("A soma dos números positivos é igual a " + somaNumeros);
            Console.ReadKey();
        }
    }
}