using System;
using tabuleiro;
using xadrez;
using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPposicao());

            Console.ReadLine();
        }
    }
}