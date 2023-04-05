using System.Drawing;

namespace Parafuso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //leia os dados para o parafuso A e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de
            //cada parafuso e a porcentagem de IPI(única) a ser acrescentada.
            Console.WriteLine("Insira o código do Parafuso A");
            int parAcod = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças do Parafuso A");
            int parAqnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário do Parafuso A");
            int parAval = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a porcentagem do Parafuso A");
            int parAporc = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o código do Parafuso B");
            int parBcod = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças do Parafuso B");
            int parBqnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário do Parafuso B");
            int parBval = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a porcentagem do Parafuso B");
            int parBporc = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Parafuso A");
            Console.WriteLine("Código A: " + parAcod);
            Console.WriteLine("Quantidade de Peças do A: " + parAqnt);
            Console.WriteLine("Valor Unitário do A: " + parAval);
            Console.WriteLine("Porcentagem de IPI do A: " + parAporc);

            Console.WriteLine("Dados do Parafuso B");
            Console.WriteLine("Código B: " + parBcod);
            Console.WriteLine("Quantidade de Peças do B: " + parBqnt);
            Console.WriteLine("Valor Unitário do B: " + parBval);
            Console.WriteLine("Porcentagem de IPI do B: " + parBporc);
        }
    }
}