using System;

namespace ex028
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis globais
            double resultado, valor1, valor2;

            Console.Clear();

            Console.Write("Informe o primeiro valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            resultado = Soma(valor1, valor2);

            Console.WriteLine($"O resultado da soma entre {valor1} + {valor2} = {Math.Round(resultado, 2)}");
        }

        public static double Soma(double n1, double n2)
        {
            double resultadoSoma;

            resultadoSoma = n1 + n2;

            return resultadoSoma;
        }
    }
}
