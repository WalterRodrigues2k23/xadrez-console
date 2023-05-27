using System;
using tabuleiro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i =0; i<tab.linhas; i++)
            {
                for (int j =0; j<tab.linhas; j++)
                    if (tab.peca(i,j)==null)
                    {
                        Console.Write("- ");
                    }else
                {
                    Console.Write(tab.peca(i,j) + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
