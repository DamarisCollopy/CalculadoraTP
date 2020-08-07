using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculadora
{
    class Base
    {
        private double soma, divisao, multiplicar, subtracao;

        public double Soma { get; set; }
        public double Subtracao { get; set; }
        public double Multiplicar { get; set; }
        public double Divisao { get; set; }


        public double resultadoSoma(double x, double y)
        {
            return soma = x + y;
        }
        public double resultadoDivisao()
        {
            double op1;
            double op2;

            do
            {
                Console.Write("Informe o op1 = ");
                op1 = double.Parse(Console.ReadLine());
                Console.Write("Informe o op2 = ");
                op2 = double.Parse(Console.ReadLine());

                if ((op1 <= 0) || (op2 <= 0))
                {
                    Console.WriteLine("Operação não é possivel ser realizada");
                    Console.ReadLine();
                }
            }
            while ((op1 <= 0) || (op2 <= 0));
            return divisao = op1 / op2;
        }

        public double resultadoMultiplicar()
        {
            double op1;
            double op2;
            do
            {
                Console.Write("Informe o op1 = ");
                op1 = double.Parse(Console.ReadLine());
                Console.Write("Informe o op2 = ");
                op2 = double.Parse(Console.ReadLine());
                if ((op1 <= 0) && (op2 <= 0))
                {
                    Console.WriteLine("Operação não é possivel ser realizada");
                    Console.ReadLine();
                }
            }
            while ((op1 <= 0) && (op2 <= 0));
            return multiplicar = op1 * op2;
        }

        public double resultadoSubtrair(double op1, double op2)
        {
            return subtracao = op1 - op2;
        }
    }
}
