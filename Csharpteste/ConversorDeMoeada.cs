namespace Csharpteste
{
    internal class ConversorDeMoeada
    {
        public static double Iof = 6.0; 
        public static double Conversor (double dolar, double comprar)
        {
            double total = comprar * dolar;
            return total + total * Iof / 100.0;
        }
    }
}
