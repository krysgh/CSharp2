// See https://aka.ms/new-console-template for more information

double MaiorNumero(double A, double B, double C)
{
    double Maior = 0;

    if (A > B)
        Maior = A;
    else
        Maior = B;

    if (Maior < C)
        Maior = C;

    return Maior;
}

double A, B, C;

Console.WriteLine("Digite um número racional: ");
A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite outro número racional: ");
B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite outro número racional: ");
C = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"O maior número entre {A}, {B} e {C} é {MaiorNumero(A, B, C)}.");
