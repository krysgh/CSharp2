// See https://aka.ms/new-console-template for more information

double Maior = 0, Menor = 0;
double MaiorNumero(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)
        {
            Maior = array[i];
        }
        else
        {
            if (Maior < array[i])
                Maior = array[i];
        }
    }

    return Maior;
}

double MenorNumero(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Menor = array[i];
        }
        else
        {
            if (Menor > array[i])
                Menor = array[i];
        }
    }

    return Menor;
}

double[] numeros = new double[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número real: ");
    numeros[i] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
}

Console.WriteLine($"MAIOR NÚMERO: {MaiorNumero(numeros)}\nMENOR NÚMERO: {MenorNumero(numeros)}");