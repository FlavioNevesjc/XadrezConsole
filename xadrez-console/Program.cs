﻿using tabuleiro;
using System;
using xadrez;

namespace xadrez_console {
    internal class Program {
        private static void Main(string[] args) {
                        try {

                        Tabuleiro tab = new Tabuleiro(8,8);
                        tab.colocarPeca(new Torre(tab,Cor.Preta),new Posicao(0,0));
                        tab.colocarPeca(new Torre(tab,Cor.Preta),new Posicao(1,3));
                        tab.colocarPeca(new Rei(tab,Cor.Preta),new Posicao(0,6));
                        tab.colocarPeca(new Rei(tab,Cor.Branca),new Posicao(0,4));


                        Tela.imprimirTabuleiro(tab);
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