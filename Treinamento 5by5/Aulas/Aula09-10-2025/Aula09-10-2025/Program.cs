// See https://aka.ms/new-console-template for more information

double CalcularMedia(double N1, double N2, double N3)
{
    return (N1 + N2 + N3) / 3.0;
}

double Nota1, Nota2, Nota3, MediaAritmetica;

Console.WriteLine("Digite a primeira nota: ");
Nota1 = double.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Digite a segunda nota: ");
Nota2 = double.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Digite a terceira nota: ");
Nota3 = double.Parse(Console.ReadLine()!);

Console.WriteLine();

MediaAritmetica = CalcularMedia(Nota1, Nota2, Nota3);

if (MediaAritmetica >= 7)
    Console.WriteLine($"APROVADO -> {MediaAritmetica:F2}");
else
    Console.WriteLine($"REPROVADO -> {MediaAritmetica:F2}");
