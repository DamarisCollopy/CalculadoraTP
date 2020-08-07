using System;
using System.ComponentModel.Design;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Base calculadora = new Base();
            int SAIR = 5;
            int opcao = Menu();

            while (opcao != SAIR)
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe o x = ");
                        double op1 = double.Parse(Console.ReadLine());
                        Console.Write("Informe o y = ");
                        double op2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado da Soma, {calculadora.resultadoSoma(op1, op2)}.");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine($"Resultado da Multiplicação, {calculadora.resultadoDivisao()}.");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine($"Resultado da Multiplicação, {calculadora.resultadoMultiplicar()}.");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Informe o x = ");
                        op1 = double.Parse(Console.ReadLine());
                        Console.Write("Informe o y = ");
                        op2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado da Subtra, { calculadora.resultadoSubtrair(op1, op2)}.");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Programa Encerrado!");
                        Console.ReadLine();
                        break;
                }
                opcao = Menu();
            }
        }

        static int Menu()
        {
            int opcao;
            Console.Clear();
            Console.WriteLine("Calculadora:");
            Console.WriteLine("1) Soma");
            Console.WriteLine("2) Divisao");
            Console.WriteLine("3) Multiplicar");
            Console.WriteLine("4) Subtrair");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nSelecione a opção: ");
            do
            {
                opcao = int.Parse(Console.ReadLine());
                if ((opcao < 1) || (opcao > 5))
                {
                    Console.WriteLine("Desculpe opção invalida");
                    Console.ReadLine();
                    return opcao;
                }
            }
            while ((opcao <= 0) || (opcao > 5));
            return opcao;
        }

    
    }
}
