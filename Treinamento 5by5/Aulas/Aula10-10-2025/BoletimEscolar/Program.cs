// See https://aka.ms/new-console-template for more information

int notas = 5, materias;
string[] cabecalho = { ("Disciplinas"), ("N1"), ("N2"), ("N3"), ("N4"), ("Média"), ("Situação") };

void ImprimirBoletim(string[] cabecalho, string[,] boletimMateriasSituacao, double[,] boletimNotas)
{
    for (int referenciaCabecalho = 0; referenciaCabecalho < cabecalho.Length; referenciaCabecalho++)
    {
        Console.Write($"{cabecalho[referenciaCabecalho]}\t");
    }

    Console.WriteLine();

    for (int referenciaMateria = 0; referenciaMateria < materias; referenciaMateria++)
    {
        Console.Write($"{boletimMateriasSituacao[referenciaMateria, 0]}\t");

        for (int referenciaNota = 0; referenciaNota < notas; referenciaNota++)
        {
            Console.Write($"{boletimNotas[referenciaMateria, referenciaNota]}\t");
        }

        Console.Write($"{boletimMateriasSituacao[referenciaMateria, 1]}");

        Console.WriteLine();

    }
}


Console.WriteLine("Digite o número de matérias desejadas: ");
materias = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine();

double[,] boletimNotas = new double[materias, notas];
string[,] boletimMateriasSituacao = new string[materias, 2];

for(int referenciaMateria = 0; referenciaMateria < materias; referenciaMateria++)
{
    Console.WriteLine($"Digite o nome da {referenciaMateria + 1}ª matéria:");
    boletimMateriasSituacao[referenciaMateria, 0] = Console.ReadLine()!;
    Console.WriteLine();
}

for(int referenciaMateria = 0; referenciaMateria < materias; referenciaMateria++)
{
    for(int referenciaNota = 0; referenciaNota < notas - 1; referenciaNota++)
    {
        Console.WriteLine($"Digite a {referenciaNota + 1}ª nota de {boletimMateriasSituacao[referenciaMateria,0]}:");
        boletimNotas[referenciaMateria, referenciaNota] = Convert.ToDouble(Console.ReadLine());
        boletimNotas[referenciaMateria, notas - 1] += boletimNotas[referenciaMateria, referenciaNota] / (notas - 1);
        Console.WriteLine();
    }
    if (boletimNotas[referenciaMateria, 4] > 5.0)
        boletimMateriasSituacao[referenciaMateria, 1] = "APROVADO";
    else
        boletimMateriasSituacao[referenciaMateria, 1] = "REPROVADO";
}

Console.WriteLine();

ImprimirBoletim(cabecalho, boletimMateriasSituacao, boletimNotas);