// See https://aka.ms/new-console-template for more information

int Numero;

do
{
    Console.WriteLine("Digite um número inteiro positivo: ");
    Numero = int.Parse(Console.ReadLine() ?? string.Empty);

    if(Numero > 0)
    {
        Console.WriteLine("CONTAGEM REGRESSIVA");

        for(int I =  Numero; I >= 0; I--)
        {
            Console.WriteLine(I);
        }
    }

} while (Numero <= 0);

