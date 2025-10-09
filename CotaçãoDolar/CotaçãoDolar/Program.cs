using System;
using System.Globalization;

namespace Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dólar ? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar/trocar ?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago = R$" + resultado.ToString("F2",  CultureInfo.InvariantCulture));
        }
    }
}