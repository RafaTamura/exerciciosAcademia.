// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Insira o valor do seu salário: ");
double sal = double.Parse(Console.ReadLine());

if (sal <= 900){
    double total = (900 + (900 * 0.05));
    Console.WriteLine(  "O seu salário total é de " + total );
}
if ((sal>900) && (sal<1400) ){
    double total = (sal + (sal * 0.08));
    Console.WriteLine(  "O seu salário total é de " + total );

}
if(sal >= 1400){
    double total = (sal + (sal * 0.1));
    Console.WriteLine(  "O seu salário total é de " + total );

}*/
//•Dados três números, verificar se eles podem 
//representar as medidas dos lados de um triângulo e,
 //classificar 
//o triângulo em equilátero, isósceles ou escaleno.
/*Console.WriteLine("Insira o primeiro número");
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

}*/

// Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura
 //lidos pelo teclado: 
//Área do triangulo = (base * altura) / 2; 
//Teste se a base ou a altura digitada não foi igual a zero.
/*
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

//Escrever um algoritmo para ler quatro valores, calcular a sua média, e escrever na tela os que são superiores à média.
Console.WriteLine("Insira o primeiro número: ");
float prim = float.Parse(Console.ReadLine());
Console.WriteLine("Insira o segundo número: ");
float sec = float.Parse(Console.ReadLine());
Console.WriteLine("Insira o terceiro número: ");
float terc = float.Parse(Console.ReadLine());
Console.WriteLine("Insira o quarto número: ");
float quart = float.Parse(Console.ReadLine());

float media = ((prim+ terc+ sec+ quart)/4);
System.Console.WriteLine("A média dos quatro números é: " + media);

if (prim > media){
    System.Console.WriteLine("O número "+ prim + " é superior a média");
}
if (sec > media){
    System.Console.WriteLine("O número "+ sec + " é superior a média");
}
if (terc > media){
    System.Console.WriteLine("O número "+ terc + " é superior a média");
}
if (quart > media){
    System.Console.WriteLine("O número "+ quart + " é superior a média");
}*/

//2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
/*System.Console.WriteLine("Digite um número: ");
float num = float.Parse(Console.ReadLine());
if (num % 2 == 0) {
    System.Console.WriteLine("O número "+ num + " é par");
} else {
    System.Console.WriteLine("O número "+ num + " é ímpar");
}*/

// Calculadora com Switch
/*System.Console.WriteLine("Digite a operação que deseja realizar: ");
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
    }*/


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