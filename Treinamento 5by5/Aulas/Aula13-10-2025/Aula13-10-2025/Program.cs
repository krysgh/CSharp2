using System.Diagnostics.Tracing;


//boletim corrigido em sala

double[,] notas = new double[5, 5];
string[,] materias = new string[5, 2];

string[,] CadastrarMateria(string titulo)
{

    if (materias[4,0] != null)
    {
        Console.WriteLine("Espaço Indisponível!");
    }

    for(int i = 0;i < 5; i++)
    {
        if (materias[i, 0] == null)
        {
            materias[i, 0] = titulo;
            break;
        }
    }

    return materias;
}

void ExibirBoletim(string[,]  materias, double[,] notas, string a)
{
    Console.WriteLine("\nAluno: " + a);
    Console.WriteLine("Materia | Nota1 | Nota2 | Nota3 | Nota4 | Media | Situacao");
    Console.WriteLine("--------------------------------------------------------");
    for(int i = 0; i < 5; i++)
    {
        Console.Write(materias[i, 0] + "\t");
        for(int j = 0;  j < 4; j++)
        {
            Console.Write($"{notas[i, j]:F2} |");
        }
        Console.Write($"{notas[i,4]:F2} ");
        Console.WriteLine(materias[i,1]);
    }
    Console.WriteLine("--------------------------------------------------------");
}

double[,] PreencherBoletim(double[,] notas)
{
    for(int i = 0;i < 5; i++)
    {
        for(int j = 0;j < 4; j++)
        {
            notas[i, j] = Random.Shared.NextDouble() * 10.0;
        }
        notas[i,4] = CalcularMedia(notas[i, 0], notas[i,1], notas[i,2], notas[i,3]);
        materias[i, 1] = AvaliarSituacao(notas[i, 4]);
    }

    return notas;
}

double CalcularMedia(double n1, double n2, double n3, double n4)
{
    return (n1+n2+n3+n4)/4.0;
}

string AvaliarSituacao(double media)
{

        if (media < 5)
            return "REPROVADO";
        else
            return "APROVADO";
}


int contador = 0;
do
{
    Console.WriteLine("Informe o nome da matéria: ");
    materias = CadastrarMateria(Console.ReadLine()!);
    contador++;

} while (contador < 5);


Console.WriteLine("Informe o nome do aluno: ");
string aluno = Console.ReadLine()!;

notas = PreencherBoletim(notas);

ExibirBoletim(materias,notas,aluno);