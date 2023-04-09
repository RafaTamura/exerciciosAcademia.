namespace Calculadora_com_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora com Switch
            System.Console.WriteLine("Digite a operação que deseja realizar: ");
            string op = Console.ReadLine(); 
            System.Console.WriteLine("Digite o primeiro número: ");
            float num1 =float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número: ");
            float num2 =float.Parse(Console.ReadLine());

            switch (op){
                case "+" :{
                    float res = num1 + num2;  
                    System.Console.WriteLine("O resultador é: " + res);
                    break;
                }

                case "-":{
                     float res = num1 - num2;  
                    System.Console.WriteLine("O resultador é: " + res);
                    break;
                }
                case "x":{
                     float res = num1 * num2;  
                    System.Console.WriteLine("O resultador é: " + res);
                    break;
                }
                case "/":{
                     float res = num1 / num2;  
                    System.Console.WriteLine("O resultador é: " + res);
                    break;
                }
                default :
                    System.Console.WriteLine("Você não digitou nenhuma das operações válidas, elas são +, -, x, /");
                    break;
                }        }
                }
            }