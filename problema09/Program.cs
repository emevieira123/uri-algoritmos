using System;

/*
Faça um programa que leia três valores e apresente o maior dos três valores lidos 
seguido da mensagem “eh o maior”. Utilize a fórmula:

MaiorAB = (a + b + abs(a - b)) / 2

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). 
Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
*/

namespace problema09
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = Console.ReadLine();

            String[] valor = line.Split(' ');
            int a = Int32.Parse(valor[0]);
            int b = Int32.Parse(valor[1]);
            int c = Int32.Parse(valor[2]);

            int MaiorAB = a;
            if (a < b || a < c)
            {
                if (b < c)
                {
                    MaiorAB = c;
                }
                else
                {
                    MaiorAB = b;
                }
            }

            Console.WriteLine(MaiorAB + " eh o maior");
        }
    }
}
