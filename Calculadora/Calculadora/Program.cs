namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Escolha entre as operações: 1 = soma, 2 = multiplicacao, 3 = divisao ou 4 = subtracao");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float secnum = float.Parse(Console.ReadLine());

            if (op == 1) 
            {
                float res = num + secnum;
                Console.WriteLine("O resultado é " + res);

            }
            if (op == 2)
            {

                float res = num * secnum;
                Console.WriteLine("O resultado é " + res);
            }
            if (op == 3)
            {

                float res = num / secnum;
                Console.WriteLine("O resultado é " + res);
            }
            if (op == 4)
            {

                float res = num - secnum;
                Console.WriteLine("O resultado é " + res);
            }






        }
    }
}