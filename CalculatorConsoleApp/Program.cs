using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            float y;

            Console.WriteLine("Digite o valor de X");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y");
            y = float.Parse(Console.ReadLine());

            Console.WriteLine(x+y);

        }
    }
}
