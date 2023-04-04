namespace Veiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o consumo médio de um automóvel(medido em Km / l), sendo que são conhecidos a distância total
            //percorrida e o volume de combustível consumido para percorrê-la(medido em l).

            Console.WriteLine(  "Digite a distânia em que o carro percorreu, em km: ");
            float dist = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o combustível consumido, em litros");
            float lit = float.Parse(Console.ReadLine());

            float cons = dist / lit;
            Console.WriteLine("O consumo do seu carro é de " + cons + " km/l");

        }
    }
}