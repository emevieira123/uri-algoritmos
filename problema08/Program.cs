using System;

/*
Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, 
sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser 
apresentado com 3 dígitos após o ponto decimal.
*/

namespace problema08
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = Console.ReadLine();

            String[] valor = line.Split(' ');
            double A = Convert.ToDouble(valor[0]);
            double B = Convert.ToDouble(valor[1]);
            double C = Convert.ToDouble(valor[2]);
            double pi = 3.14159;

            double triangulo = (A * C) / 2;
            double circulo = pi * (C * C);
            double trapezio = (B + A) * C / 2;
            double quadrado = B * B;
            double retangulo = A * B;

            System.Console.WriteLine("TRIANGULO: {0:f3}", triangulo);
            System.Console.WriteLine("CIRCULO: {0:f3}", circulo);
            System.Console.WriteLine("TRAPEZIO: {0:f3}", trapezio);
            System.Console.WriteLine("QUADRADO: {0:f3}", quadrado);
            System.Console.WriteLine("RETANGULO: {0:f3}", retangulo);
        }
    }
}
