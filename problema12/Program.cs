using System;

namespace problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            int cem, cinquenta, vinte, dez, cinco, dois, um, resto;
            int valor1 = Int32.Parse(Console.ReadLine());

            cem = valor1 / 100;
            resto = valor1 % 100;
            cinquenta = resto / 50;
            vinte = ((resto % 50) / 20);
            dez = (((resto % 50) % 20) / 10);
            cinco = ((((resto % 50) % 20) % 10) / 5);
            dois = (((((resto % 50) % 20) % 10) % 5) / 2);
            um = ((((((resto % 50) % 20) % 10) % 5) % 2) / 1);

            System.Console.WriteLine(valor1);
            System.Console.WriteLine(cem + " nota(s) de R$ 100,00");
            System.Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            System.Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            System.Console.WriteLine(dez + " nota(s) de R$ 10,00");
            System.Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            System.Console.WriteLine(dois + " nota(s) de R$ 2,00");
            System.Console.WriteLine(um + " nota(s) de R$ 1,00");
        }
    }
}
