namespace MediaQuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo para ler quatro valores, calcular a sua média, e escrever na tela os que são superiores à média.
            Console.WriteLine("Insira o primeiro número: ");
                float prim = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
                float sec = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número: ");
                float terc = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o quarto número: ");
                float quart = float.Parse(Console.ReadLine());

                float media = ((prim + terc + sec + quart) / 4);
                System.Console.WriteLine("A média dos quatro números é: " + media);

                    if (prim > media)
                    {
                        System.Console.WriteLine("O número " + prim + " é superior a média");
                    }
                    if (sec > media)
                    {
                        System.Console.WriteLine("O número " + sec + " é superior a média");
                    }
                    if (terc > media)
                    {
                        System.Console.WriteLine("O número " + terc + " é superior a média");
                    }
                    if (quart > media)
                    {
                        System.Console.WriteLine("O número " + quart + " é superior a média");
                    }
            }
        }
}