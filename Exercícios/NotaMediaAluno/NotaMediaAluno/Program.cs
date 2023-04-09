namespace NotaMediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            //se a média das duas notas for maior ou igual a 7,0. 

            System.Console.WriteLine("Insira a primeira nota: ");
            float not1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira a segunda nota: ");
            float not2 = float.Parse(Console.ReadLine());

            float media = (not1 + not2) / 2;
            System.Console.WriteLine(media >= 7.0 ? " O aluno foi aprovado com " + media + " de média" : "O aluno foi reprovado com " + media + " de média");
        }
    }
}