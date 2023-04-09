namespace AreaDoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura
            //lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2; 
            //Teste se a base ou a altura digitada não foi igual a zero.

            Console.WriteLine("Vamos calcular a área do triângulo!");
            Console.WriteLine("Insira a base do triângulo: ");
             float bas = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura do triângulo: ");
             float altura = float.Parse(Console.ReadLine());
                if (bas > 0 && altura > 0){
                float area = ((bas*altura)/2); 

                Console.WriteLine("A área do triângulo é igual a: " + area);

                } else {
                    Console.WriteLine("A base ou a altura não podem ser menores ou igual a Zero");
                }
                        }
                    }
            }