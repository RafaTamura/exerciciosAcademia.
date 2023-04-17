//                                                          FOR 

/*for permite implementar laços de repetição, definir trechos de código de um programa que se repetem
necessita de uma variável contadora que deve ser inicializada com um valor 
necessita de uma condição
for (valor inicial; condição; incremento ou decremento ){
    bloco de instrução */



//Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x 
//elevado na y sem utilizar a função pow.

//Escreva um algoritmo para calcular o fatorial de um número.

//Exercicio opção

/*int opcao, i;
    System.Console.WriteLine("Digite um número entre 1 a 4: ");
    opcao = int.Parse(Console.ReadLine());
for (i = opcao; i>0; i++ ){
    if (opcao >= 1 && opcao <= 4){
break;
} else {
    System.Console.WriteLine("Digite um número entre 1 a 4:");
    opcao = int.Parse(Console.ReadLine());
}
    }*/

/*1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

Exemplo:
Digite um número inteiro positivo: -8
Valor incorreto!
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.
*/

/*int num, i, par, soma=0;
System.Console.WriteLine("Digite um número positivo: ");
num = int.Parse(Console.ReadLine());

if (num > 0){
    System.Console.WriteLine("Número Digitado: " + num);

    par = num%2;
    if (par == 0){
        for(i=2; i<num;soma=i+2){
        }
            System.Console.WriteLine("Números pares " + soma );
    }
        } else if (num <= 0){
    System.Console.WriteLine("Valor Incorreto");


}

*/



/*
                                                           RESOLVIDOS

//Escreva um algoritmo leia pelo teclado um valor inteiro 
//chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x.
int i;
System.Console.WriteLine("Insira o valor que gostaria que pulasse: ");
int x = int.Parse(Console.ReadLine());
for (i=0; i<=100;i=i+x){
    System.Console.WriteLine(i);
}

//Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x
//lido utilizando laços de repetição, e mostre na tela.
    int num, i, res;
    System.Console.WriteLine("Insira um número para calcular a tabuada: ");
    num = int.Parse(Console.ReadLine());
    for (i=0; i<=10; i++ ){
        res= num*i;
        System.Console.WriteLine(num + " x " + i + " = " + res);
    }

//•Escreva um algoritmo leia pelo teclado os dois valores inteiros chamados 
//inicio e fim, e então mostre todos os números entre inicio e fim.
    int i;
    System.Console.WriteLine("Insira o número inicial da contagem: ");
    int ini = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Insira o número final da contagem: ");
    int fim = int.Parse(Console.ReadLine());
if (ini < fim){
    for (i = ini; i <= fim; i++){
        System.Console.WriteLine(i);
    }
}else if (ini > fim) {
    for (i = ini; i >= fim; --i){
        System.Console.WriteLine(i);
    }
} else {
    System.Console.WriteLine("Os dois números são iguais");
}
// 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
//Se o usuário digitar 0 o programa em VS deve parar. 
//Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   

//for (valor inicial; condição; incremento ou decremento )
int num, i, par, j;
bool primo;

for (;;){
System.Console.WriteLine("Digite um número");
num = int.Parse(Console.ReadLine());

par = num%2;

// Par ou ímpar
if (par == 0 && num > 0){
    System.Console.WriteLine("O número " + num + " é par!");
    } if (par == 1){
    System.Console.WriteLine("O número " + num + " é ímpar!");
    } if (num == 0){
        break;
        }
// Primo 
    primo = true;
    if (num < 2) {
        primo  = false;
    }
    for (i = 2; i < num; i++) {

        if (num % i == 0) {
            primo=false;
            break;
        }
}  if (primo){
        System.Console.WriteLine("O número é primo"); 
        } else {
            System.Console.WriteLine("O número não é primo");
            } 
        }

//Escreva um algoritmo para ler um número n,
//e em seguida ler pelo teclado calcular a média de idade de n pessoas.

  float media;
    int i, n, id, soma=0;

    System.Console.WriteLine("Insira a quantidade de pessoas da pesquisa: ");
    n = int.Parse(Console.ReadLine());
    for (i=n; i>0; i--){
        System.Console.WriteLine("Digite a idade da pessoa: ");
        id = int.Parse(Console.ReadLine());
        soma+=id;
        }
    media = soma / n;
    System.Console.WriteLine("A média da idade das pessoas é de "+ media);


//Escreva um algoritmo que mostre todos os números de 20 a 5.
    int i;
    for (i = 20; i > 4; --i ){
        System.Console.WriteLine(i);
    };
*/

//                                              WHILE E DO WHILE
// while (se aqui for true irá acontecer, mas não sei quando termina){}
// for é quando você sabe que tem um fim
// do while faz uma interação com o código antes de entrar no while

//**********************************************VETORES******************************************
/*int[] vetor = new int[3];

 

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe um valor para a posição " + i + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

 


            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("O vetor possui na posição " + i + " o valor " + vetor[i]);
                Console.WriteLine("vetor[" + i + "] = " + vetor[i]);
            }
*/
/*
1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a 
quantidade de números pares e ímpares.
int num =10;
int val ,par, soma=0,somaim=0, i, j;

 int [] vetor = new int[num];
 for (i=0; i<num; i++){
    System.Console.WriteLine("Digite um valor para inserir na tabela: ");
    val= int.Parse(Console.ReadLine());
    vetor[i] = val;
    par = val%2;

    if (par == 0){
            soma++;
    }  else{
            somaim++;
        }
 }
            System.Console.WriteLine("A quantidade de números pares neste vetor é de " + soma);
            System.Console.WriteLine("A quantidade de números ímpares neste vetor é de " + somaim);
*/
/*2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos 
elementos da mesma posição, armazenando o resultado em um outro vetor.
int qntd = 3, val1, val2, i; 
int [] vetor1 = new int[qntd];
int [] vetor2 = new int[qntd];
int [] soma = new int[qntd];

for (i=0; i<qntd; i++){
System.Console.WriteLine("Digite o valor para inserir no primeiro vetor: ");
val1 = int.Parse(Console.ReadLine());
vetor1[i] = val1;
}
for (i=0; i<qntd; i++){
System.Console.WriteLine("Digite o valor para inserir no segundo vetor: ");
val2 = int.Parse(Console.ReadLine());
vetor2[i] = val2;
}
System.Console.WriteLine("A soma dos dois vetores é ");
for (i=0; i<qntd; i++){
soma[i] = vetor1[i] + vetor2[i]; 
System.Console.WriteLine("linha "+ i + "[" + soma[i]+"]");

*/
//1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A
// 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
int[,] num = new int[5,3] ;
Random gerador = new Random();
int i;

for (i=0; i<5; i++){
num[i]= gerador.Next(10,50);
}
System.Console.Write(num[i]);

