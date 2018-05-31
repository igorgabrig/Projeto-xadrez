using System;
using tabuleiro;//Para usar a classe Posicao, pois a mesma possui tabuleiro como namespace.

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            Posicao P = new Posicao(3,4);

            Console.WriteLine("Posicao: " + P);

            Console.ReadLine();

        }
    }
}
