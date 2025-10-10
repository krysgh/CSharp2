// See https://aka.ms/new-console-template for more information

double[] precos = new double[5];
double[] precosDesconto = new double[5];
const double desconto = 0.10;

for (int i = 0;i < precos.Length; i++)
{
    Console.WriteLine($"Digite o preço do {i + 1}º produto: ");
    precos[i] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
}

for (int i = 0; i < precos.Length; i++)
    precosDesconto[i] = precos[i] * (1 - desconto);

Console.WriteLine("ID\tPREÇOS ORIGINAIS\tPREÇOS COM 10% DE DESCONTO");

for (int i = 0; i < precos.Length; i++)
    Console.WriteLine($"{i + 1}\t{precos[i]}\t\t\t{precosDesconto[i]:F2}");