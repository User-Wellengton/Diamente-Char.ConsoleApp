using System;

namespace DesenhoCaracter
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int tamanhoDiamante = 0;

            Console.WriteLine("Diamente:");

            Console.WriteLine("Digite o tamanho do diamente, utilizar números ímpares.");
            tamanhoDiamante = Convert.ToInt32(Console.ReadLine());






            int quantidadeEspacos = (tamanhoDiamante - 1) / 2; //3

            int quantidadeDeX = 1;

            int quantidadeDeLinhas = (tamanhoDiamante - 1) / 2; //3

            for (int linha = 0; linha < quantidadeDeLinhas; linha++) // escreve quantidade de linhas 
            {
                for (int i = 0; i < quantidadeEspacos; i++) //escreve os espaços
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < quantidadeDeX; i++)   //escreve os espacos com X
                {
                    Console.Write("x");
                } 

                quantidadeEspacos--;       //diminiu os espacos a cada loop do primeiro FOR
                quantidadeDeX += 2;        //aumenta os "X" a cada loop do primeiro FOR

                Console.WriteLine();
            }

            

            

            for (int coluna = 0; coluna < tamanhoDiamante; coluna++)
            {
                Console.Write("x");
            } // escreve os espacos em X na parte do meio 

            quantidadeEspacos++;
            quantidadeDeX -= 2;

            Console.WriteLine();

            

           

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < quantidadeEspacos; i++) //escreve os espaços
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < quantidadeDeX; i++)       //escreve os "X"
                {
                    Console.Write("x");
                }

                quantidadeEspacos++;
                quantidadeDeX -= 2;

                Console.WriteLine();
            }

            

            Console.ReadLine();




            

        }
    }
}
