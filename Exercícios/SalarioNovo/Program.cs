namespace SalarioNovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do seu salário: ");
            double sal = double.Parse(Console.ReadLine());

            if (sal <= 900)
            {
                double total = (900 + (900 * 0.05));
                Console.WriteLine("O seu salário total é de " + total);
            }
            if ((sal > 900) && (sal < 1400))
            {
                double total = (sal + (sal * 0.08));
                Console.WriteLine("O seu salário total é de " + total);

            }
            if (sal >= 1400)
            {
                double total = (sal + (sal * 0.1));
                Console.WriteLine("O seu salário total é de " + total);

            }
        }
    }
}