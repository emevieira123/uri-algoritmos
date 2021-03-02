using System;

/*
Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer 
no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 
casas decimais após a vírgula, segundo a fórmula:

Distancia = RAIZ((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1))

Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém 
dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores 
de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 
casas após o ponto decimal.
*/

namespace problema10
{
    class Program
    {
        static void Main(string[] args)
        {
            String line1 = Console.ReadLine();
            String line2 = Console.ReadLine();

            String[] valor1 = line1.Split(' ');
            double x1 = Convert.ToDouble(valor1[0]);
            double y1 = Convert.ToDouble(valor1[1]);

            String[] valor2 = line2.Split(' ');
            double x2 = Convert.ToDouble(valor2[0]);
            double y2 = Convert.ToDouble(valor2[1]);

            double X = (x2 - x1) * (x2 - x1);
            double Y = (y2 - y1) * (y2 - y1);
            double soma = X + Y;

            double raiz = Math.Sqrt(soma);

            System.Console.WriteLine(raiz);
        }
    }
}
