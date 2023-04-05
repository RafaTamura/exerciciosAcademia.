using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
          //  A fórmula da conversão é F = (9 * C + 160) / 5.
            Console.WriteLine("Conversor de Temperatura");
            Console.WriteLine("Insira a temperatura em Celsius");
            int cel = int.Parse(Console.ReadLine());

            int fahr = ((9 * cel + 160) / 5);
            Console.WriteLine("A temperatura " +  cel + " Celsius, é igual a " + fahr + " Fahrenheit"); 
        }
    }
}