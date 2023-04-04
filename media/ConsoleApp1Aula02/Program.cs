namespace ConsoleApp1Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            Console.WriteLine("Vamos calcular a média aritmética de dois números que você digitar: ");
            Console.WriteLine("Digite o primeiro número: ");
            float first = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o segundo número: ");
            float sec = float.Parse(Console.ReadLine());

            float res = (first + sec) / 2;  

            Console.WriteLine( "A média aritmética entre os números " + first + " e " + sec + " é de " +  res );
        }

    }
}