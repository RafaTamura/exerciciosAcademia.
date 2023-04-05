namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //leia o número de um vendedor, o seu salário fixo, o total de vendas por ele efetuadas e o percentual
           //que ganha sobre o total de vendas. Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total
           //do vendedor.
            Console.WriteLine("Calcule o seu salário total! ");
            Console.WriteLine("Digite o seu número de vendedor: ");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu salário fixo: ");
            float sal = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu total de vendas: ");
            float vend = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o percentual que tu ganha sobre o total de vendas: ");
            float porc = float.Parse(Console.ReadLine());

            float total = (vend * (porc / 100) + sal);

            Console.WriteLine("O salário total do vendedor " + num + " é de " + total + " reais");

        }
    }
}