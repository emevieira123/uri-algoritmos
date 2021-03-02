using System;

/*
Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, 
o valor unitário de cada peça 1, o código de uma peça 2, o número de 
peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o 
valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, 
respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de 
deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser 
apresentado com 2 casas após o ponto.
*/

namespace problema07
{
    class Program
    {
        static void Main(string[] args)
        {
            String line1 = Console.ReadLine();
            String line2 = Console.ReadLine();

            String[] values1 = line1.Split(' ');
            int codPeca1 = Int32.Parse(values1[0]);
            int numPecas1 = Int32.Parse(values1[1]);
            double valorPeca1 = Convert.ToDouble(values1[2]);

            String[] values2 = line2.Split(' ');
            int codPeca2 = Int32.Parse(values2[0]);
            int numPecas2 = Int32.Parse(values2[1]);
            double valorPeca2 = Convert.ToDouble(values2[2]);

            double total = (valorPeca1 * numPecas1) + (valorPeca2 * numPecas2);

            System.Console.WriteLine("VALOR A PAGAR: R$ {0:f2}", total);
        }
    }
}
