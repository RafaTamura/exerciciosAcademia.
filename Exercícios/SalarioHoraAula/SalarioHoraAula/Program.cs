namespace SalarioHoraAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora 
            //recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.

            System.Console.WriteLine( "Insira a quantidade de horas aulas dadas, primeiro prof: " );
                int hor1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine( "Insira o valor de hora, primeiro prof: " );
                float  val1= float.Parse(Console.ReadLine());
            System.Console.WriteLine( "Insira a quantidade de horas aulas dadas, segundo prof: " );
                int hor2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine( "Insira o valor de hora, segundo prof" );
                float  val2= float.Parse(Console.ReadLine());

                float tot1 = hor1*val1;
                float tot2 = hor2 * val2;
                System.Console.WriteLine("O primeiro professor recebe "+ tot1 + " e o segundo professor recebe " + tot2 );
                    if (tot1>tot2){
                    System.Console.WriteLine( "O primeiro professor recebe mais " );
                    }
                    else if (tot1 == tot2){
                    System.Console.WriteLine( "Os dois professores recebem o mesmo valor " );
                    } else {
                        System.Console.WriteLine("O segundo professor recebe mais que o primeiro professor");
                    }
                            }
                    }
                }