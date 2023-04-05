using System.Runtime.Intrinsics.X86;

namespace Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //que receba a data na forma DDMMAAAA e imprima na 
            // forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
            Console.WriteLine( "Vamos transformar as datas em outros formatos" );
            Console.WriteLine("Primeiro digite o dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Temos o formato " + mes + "/" + dia + "/" + ano);
            Console.WriteLine("Temos o formato " + ano + "/" + mes + "/" + dia);
        }
    }
}