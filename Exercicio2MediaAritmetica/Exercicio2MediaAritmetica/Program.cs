namespace Exercicio2MediaAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular a média aritmética de 4 números que você digitar");
            Console.WriteLine("Digite o primeiro número: ");
            float prim = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float sec = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            float terc = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número: ");
            float quart = float.Parse(Console.ReadLine());

            float res = ((prim + sec + terc + quart) / 4);

            Console.WriteLine( "A média aritmética entre os números " + prim + " , " + sec + " , " + terc + " e " + quart + " é de " + res );
        }
    }
}