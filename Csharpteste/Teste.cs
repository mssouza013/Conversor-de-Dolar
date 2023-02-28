using Csharpteste;
using System;
using System.Globalization;

namespace CsharpTeste;
class Teste
{
    static void Main(string[] args)
    {
        Console.Write("Qual a cotação do dólar? ");
        double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        double comprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double result = ConversorDeMoeada.Conversor(dolar, comprar);
        Console.Write("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
    }
}