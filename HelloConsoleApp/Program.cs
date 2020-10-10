using System;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Digite seu nome:");
            name = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Bem vindo! " + name);

            if (age >= 18)
                Console.WriteLine("Você é maior de idade");
            else
                Console.WriteLine("Você é menor de idade");
        }
    }
}
