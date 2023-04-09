namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
//•Dados três números, verificar se eles podem 
//representar as medidas dos lados de um triângulo e, classificar o triângulo em equilátero, isósceles ou escaleno.
    Console.WriteLine("Insira o primeiro número");
    int prim = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o segundo número");
    int sec = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o terceiro número");
    int terc = int.Parse(Console.ReadLine());
    //equilatero
    if (prim < sec+terc && sec < prim+terc && terc< prim + sec){

    if (prim == sec && sec==terc){
    Console.WriteLine("Triângulo equilátero");

    } else if (prim != sec && sec != terc && prim != terc){
    Console.WriteLine("Triângulo escaleno");

    } else {
        Console.WriteLine("Triângulo isósceles ");
    }
    } else {
        Console.WriteLine("Não é um triângulo");

    }        }
        }
    }