using System;

namespace Calculadora_De_Par_e_Impar_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##BEM VINDO(A) AO CONTADOR DE PARES E ÍMPARES##");
            Console.WriteLine("POR FAVOR DIGITE A QUANTIDADE DE LINHAS QUE DESEJA");
            Console.WriteLine();

            string linhas = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("AGORA, POR FAVOR DIGITE A QUANTIDADE DE COLUNAS QUE DESEJA");
            Console.WriteLine();

            string colunas = Console.ReadLine();

            try
            {
                // Criação de variáveis
                int nLinhas = int.Parse(linhas);
                int nColunas = int.Parse(colunas);
                int qtdPares = 0;
                int qtdImpares = 0;
                int[,] matriz = new int[nLinhas, nColunas];

                //Percorrer matriz e contar quantidade de pares e ímpares
                for (int i = 0; i < nLinhas; i++)
                {
                    for (int j = 0; j < nColunas; j++)
                    {
                        if (matriz[i, j] % 2 == 0)
                        {
                            qtdPares++;
                        }
                        else
                        {
                            qtdImpares++;
                        }
                    }
                }

                // Retornar e informar o valor que tem maior ocorrência

                if (qtdPares > qtdImpares)
                {
                    Console.WriteLine($"Tivemos uma maior ocorrência de pares. Totalizando: {qtdPares}");
                }
                else
                {
                    Console.WriteLine($"Tivemos uma maior ocorrência de Ímpares. Totalizando: {qtdImpares}");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine($"Não foi possível processar o que foi digitado. Por favor tente novamente. Erro: {e}");
            }
        }
    }
}
