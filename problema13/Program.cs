using System;

namespace problema13
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos;

            int N = Int32.Parse(Console.ReadLine());

            minutos = N / 60;
            segundos = N % 60;
            horas = minutos / 60;
            minutos %= 60;

            System.Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);

        }
    }
}
