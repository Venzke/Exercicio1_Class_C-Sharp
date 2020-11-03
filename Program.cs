using System;
using System.Globalization;


namespace Exercicio2
{
    class Program
    {
        static void Main()
        {
            Funcionario x, y;

            x = new Funcionario();
            y = new Funcionario();

            Console.Write("Insira o nome do primeiro funcionário: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Insira o salário do primeiro funcionário: ");
            x.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Insira o nome do segundo funcionário: ");
            y.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Insira o salário do segundo funcionário: ");
            y.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            float media = (x.Salario + y.Salario) / 2;

            Console.WriteLine();
            Console.Write("A média do salário da empresa é: {0:F2}", media);


            Console.Read();
        }
    }
}
