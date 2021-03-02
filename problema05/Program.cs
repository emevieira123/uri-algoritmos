﻿using System;

/*
Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de 
A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Entrada
O arquivo de entrada contém 4 valores inteiros.

Saída
Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, 
com um espaço em branco antes e depois da igualdade.
*/

namespace problema05
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            int C = Int32.Parse(Console.ReadLine());
            int D = Int32.Parse(Console.ReadLine());

            int DIFERENCA = (A * B - C * D);

            System.Console.WriteLine("DIFERENCA = {0}", DIFERENCA);
        }
    }
}
