namespace Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int id = int.Parse(Console.ReadLine());

            if (id >= 18) {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }

        }
    }
}