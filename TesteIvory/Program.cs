using System;

namespace TesteIvory
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            var matriz = new string[3, nome.Length + 2];

            var aux1 = 1;
            var aux2 = 0;



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < nome.Length + 2; j++)
                {
                    if (i == 0)
                    {
                        matriz[i, j] = aux1.ToString();
                        aux1++;
                    }
                    else if (i == 1)
                    {
                        if (j == 0)
                        {
                            matriz[i, j] = (3 * (nome.Length + 2) - nome.Length).ToString();
                            aux2 = aux1;
                            aux1 = int.Parse(matriz[i, j]);
                        }
                        else if (j == nome.Length + 1)
                        {
                            matriz[i, j] = aux2.ToString();
                        }
                        else
                        {
                            matriz[i, j] = nome[j - 1].ToString();
                        }
                    }
                    else
                    {
                        matriz[i, j] = (aux1 - 1).ToString();
                        aux1--;
                    }
                }
            }

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < nome.Length + 2; j++)
                {
                    Console.Write($"|{matriz[i, j],4}|");
                }
                Console.WriteLine();
            }
        }
    }
}
