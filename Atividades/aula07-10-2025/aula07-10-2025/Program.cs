/*
 TEORIA
 
Console.WriteLine("Hello, World!");
Console.WriteLine("This is a test project for C# 13 features.");
Console.Write("Qualquer coisa");
Console.Write("Qualquer coisa");
Console.ReadKey();
*/

/*EXERCICIO:
FAÇA um programa que leia um nome e EXIBA o mesmo.
*/

using System.Globalization;

string Nome;

Console.Write("Digite o seu nome: ");

Nome = Console.ReadLine()??string.Empty;

Console.WriteLine("Seu nome é " + Nome);

Console.WriteLine("\n\n");



/*EXERCICIO:
FAÇA um programa que leia 2 números, EXECUTE as 4 operações matemáticas e EXIBA o seu resultado.
*/

double Num1, Num2, Resultado;

Console.WriteLine("Digite o primeiro número: ");
Num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
Num2 = Convert.ToDouble(Console.ReadLine());

Resultado = Num1 + Num2;
Console.WriteLine("A soma é: " + Resultado);

Resultado = Num1 - Num2;
Console.WriteLine("A diferença é: " + Resultado);

Console.WriteLine("A multiplicação é: " + (Num1 * Num2));

//INTERPOLACAO $ {}
if (Num2 == 0)
{
    Console.WriteLine("Divisão por zero não é permitida.");
}
else
{
    Resultado = Num1 / Num2;
    Console.WriteLine($"O resultado da divisão é: {Resultado} ");
}

Console.WriteLine("\n\n");


//EXERCICIOS PARA CASA:

//1

double Nota1, Nota2, Nota3, Media;

Console.WriteLine("Digite a primeira nota: ");
Nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
Nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
Nota3 = Convert.ToDouble(Console.ReadLine());

Media = (Nota1 + Nota2 + Nota3) / 3;

if (Media >= 7)
{
    Console.WriteLine("Aprovado");
}
else { 
    Console.WriteLine("Reprovado");
}

Console.WriteLine("\n\n");



//2

int NumInteiro;

Console.WriteLine("Digite um número inteiro: ");
NumInteiro = int.Parse(Console.ReadLine()??string.Empty);

if (NumInteiro % 2 == 0)
{
    Console.WriteLine(NumInteiro + " é Par\nResultado = " + (NumInteiro%2));
}
else
{
    Console.WriteLine(NumInteiro + " é Ímpar\nResultado = " + (NumInteiro % 2));
}

Console.WriteLine("\n\n");



//3

double Numero1, Numero2;

Console.WriteLine("Digite o primeiro número: ");
Numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
Numero2 = Convert.ToDouble(Console.ReadLine());

if(Numero1 > Numero2)
    Console.WriteLine(Numero1 + " é maior que " + Numero2);
else
    Console.WriteLine(Numero2 + " é maior que " + Numero1);

Console.WriteLine("\n\n");




//4

double Peso, Altura, IMC;

Console.WriteLine("Digite o seu peso (kg): ");
Peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a sua altura (m): ");
Altura = Convert.ToDouble(Console.ReadLine());

IMC = Peso / (Altura * Altura);

if(IMC < 18.5)
    Console.WriteLine("Abaixo do peso");
else if (IMC >= 18.5 && IMC < 24.9)
    Console.WriteLine("Peso normal");
else if (IMC >= 25 && IMC < 29.9)
    Console.WriteLine("Sobrepeso");
else
    Console.WriteLine("Obesidade");

Console.WriteLine("\n\n");




//5

int NumeroInteiro1, NumeroInteiro2;

Console.WriteLine("Digite o primeiro número inteiro: ");
NumeroInteiro1 = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Digite o segundo número inteiro: ");
NumeroInteiro2 = int.Parse(Console.ReadLine() ?? string.Empty);

if(NumeroInteiro1 % NumeroInteiro2 == 0)
    Console.WriteLine(NumeroInteiro1 + " é múltiplo de " + NumeroInteiro2);
else
    Console.WriteLine(NumeroInteiro1 + " não é múltiplo de " + NumeroInteiro2);

Console.WriteLine("\n\n");



//6

double Preco;
int FormaPagamento;

Console.WriteLine("Digite o preço do produto: ");
Preco = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha a forma de pagamento:\n1 - À vista (10% de desconto\n2- Parcelado");
FormaPagamento = int.Parse(Console.ReadLine() ?? string.Empty);

if(FormaPagamento == 1)
{
    Preco *= 0.90; 
    Console.WriteLine("Preço com desconto: " + Preco);
}
else
{
    Console.WriteLine("Preço original: " + Preco);
}

Console.WriteLine("\n\n");



//7

double Lado1, Lado2, Lado3;

Console.WriteLine("Digite o primeiro lado do triângulo: ");
Lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo lado do triângulo: ");
Lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado do triângulo: ");
Lado3 = Convert.ToDouble(Console.ReadLine());

if (Lado1 < (Lado2 + Lado3) && 
    Lado2 < (Lado1 + Lado3) && 
    Lado3 < (Lado1 + Lado2)) 
{ 
    if(Lado1 == Lado2 && 
       Lado2 == Lado3)
        Console.WriteLine("Triângulo Equilátero");

    else if (Lado1 == Lado2 ||
             Lado1 == Lado3 || 
             Lado2 == Lado3)
        Console.WriteLine("Triângulo Isósceles");
    else
        Console.WriteLine("Triângulo Escaleno");
}
else
{
    Console.WriteLine("Os lados não formam um triângulo.");
}

Console.WriteLine("\n\n");



//8

double NotaA, NotaB, NotaC, PesoA, PesoB, PesoC, MediaPonderada;

Console.WriteLine("Digite a primeira nota: ");
NotaA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
NotaB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
NotaC = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso da primeira nota: ");
PesoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso da segunda nota: ");
PesoB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso da terceira nota: ");
PesoC = Convert.ToDouble(Console.ReadLine());

MediaPonderada = ((NotaA * PesoA) + (NotaB * PesoB) + (NotaC *PesoC))/(PesoA + PesoB + PesoC);

if(MediaPonderada >= 9)
    Console.WriteLine("A");
else if (MediaPonderada >= 7 && MediaPonderada < 9)
    Console.WriteLine("B");
else if (MediaPonderada >= 5 && MediaPonderada < 7)
    Console.WriteLine("C");
else
    Console.WriteLine("D");

Console.WriteLine("\n\n");

