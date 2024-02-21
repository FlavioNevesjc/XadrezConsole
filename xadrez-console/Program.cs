using tabuleiro;
using System;
using xadrez;

namespace xadrez_console {
    internal class Program {
        private static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPosiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPosiveis);
                    
                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            
/*            PosicaoXadrez pos = new PosicaoXadrez('c',7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());*/
        }
    }
}