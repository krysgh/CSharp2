// See https://aka.ms/new-console-template for more information

int Numeros, Soma = 0;

do
{
    Console.WriteLine("Digite um número inteiro");
    Numeros = int.Parse(Console.ReadLine()??string.Empty);

    Console.WriteLine("\n");

    if (Numeros % 2 == 0) 
    {
        Soma += Numeros; 
        
    }


} while (Numeros > 0);

Console.WriteLine("SOMA: " +  Soma);