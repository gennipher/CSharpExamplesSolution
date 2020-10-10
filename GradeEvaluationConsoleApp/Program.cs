using System;

namespace GradeEvaluationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno");
            float grade = float.Parse(Console.ReadLine());


            if (grade == 0)
                Console.WriteLine("Que Vergonha!");
            else if (grade > 0 && grade < 5)
                Console.WriteLine("Precisa estudar muito mais!");
            else if (grade >= 5 && grade < 8)
                Console.WriteLine("Tem que estudar mais...");
            else if (grade >= 8 && grade < 10)
                Console.WriteLine("Falta pouco!");
            else if (grade == 10)
                Console.WriteLine("Parabéns! =)");
            else
                Console.WriteLine("Nota inválida!");
        }
    }
}
