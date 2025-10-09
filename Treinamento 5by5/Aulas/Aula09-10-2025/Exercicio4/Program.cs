// See https://aka.ms/new-console-template for more information


double ConverterParaDolar(double ValorEmReais, double TaxaCambio)
{
    TaxaCambio *= 0.01;

    return (ValorEmReais / 5.34) - (TaxaCambio * ValorEmReais);
}

double Real, TaxaCambio;

Console.WriteLine("Digite um valor em real: ");
Real = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a taxa de câmbio em decimal: ");
TaxaCambio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"REAL: {Real:F2}\nDOLAR: {ConverterParaDolar(Real, TaxaCambio):F2}");