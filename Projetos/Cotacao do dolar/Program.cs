using System;

namespace Cotacao_do_dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, dolar, total;

            Console.Write("Qual e a cotacao do dolar? ");
            cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares voce vai comprar? ");
            dolar = double.Parse(Console.ReadLine());

            total = ConversorDeMoeda.Conversao(cotacao, dolar);

            Console.WriteLine($"Valor a ser pago em reais: {total:F2}");
        }
    }
}