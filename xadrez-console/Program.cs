﻿using tabuleiro;
using System;
using xadrez_console;

internal class Program {
    private static void Main(string[] args) {

        Tabuleiro tab = new Tabuleiro(8,8);

        Tela.imprimirTabuleiro(tab);


    }
}