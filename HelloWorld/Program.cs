// See https://aka.ms/new-console-template for more information



//2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
/*System.Console.WriteLine("Digite um número: ");
float num = float.Parse(Console.ReadLine());
if (num % 2 == 0) {
    System.Console.WriteLine("O número "+ num + " é par");
} else {
    System.Console.WriteLine("O número "+ num + " é ímpar");
}


//4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora 
//recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.

/*System.Console.WriteLine( "Insira a quantidade de horas aulas dadas, primeiro prof: " );
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
}*/

//Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
//se a média das duas notas for maior ou igual a 7,0. 

System.Console.WriteLine("Insira a primeira nota: ");
float not1 = float.Parse(Console.ReadLine());
System.Console.WriteLine("Insira a segunda nota: ");
float not2 = float.Parse(Console.ReadLine());

float media = (not1+not2)/2;
System.Console.WriteLine(media >= 7.0 ?" O aluno foi aprovado com " + media +" de média":"O aluno foi reprovado com " + media + " de média");