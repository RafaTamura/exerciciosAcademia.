namespace TrocaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
//si os valores de duas variáveis A e B.
            Console.WriteLine("Vamos trocar os números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int prim = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int sec = int.Parse(Console.ReadLine());

            int aux = prim;
            prim = sec;
            sec = prim;

            Console.WriteLine("O primeiro número agora é " + prim + " e o segundo é " + aux);

        }
    }
}