using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace TP.Aula03Exer03
{
    internal static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de linhas da matriz");
            int linhas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de colunas da matriz");
            int colunas = Convert.ToInt32(Console.ReadLine());

            int[,] arrayUsuario = new int[linhas, colunas];
            int conteudoArray = 1; 


            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    arrayUsuario[i, j] = conteudoArray++;
                }
            }

            Console.WriteLine("Iniciando matriz");

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.WriteLine(arrayUsuario[i,j]);
                }
            }

        }

    }

}
