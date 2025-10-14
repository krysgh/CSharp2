// See https://aka.ms/new-console-template for more information

using _3PessoasNoVetor;
using System.IO.Pipes;
using System.Reflection.PortableExecutable;


#region VetorPessoa
/*
Pessoa[] vetorPessoas = new Pessoa[3];

Pessoa[] InserirPessoas(Pessoa[] vetorPessoa)
{

    for (int i = 0; i < 3; i++)
    {
        vetorPessoa[i] = new Pessoa();

        Console.Write($"Digite o nome da pessoa {i + 1}: ");
        vetorPessoa[i].SetNome(Console.ReadLine()!);
        Console.WriteLine();

        Console.Write($"Digite o sobrenome da pessoa {i + 1}: ");
        vetorPessoa[i].SetSobrenome(Console.ReadLine()!);
        Console.WriteLine();

        Console.Write($"Digite a idade da pessoa {i + 1}: ");
        vetorPessoa[i].SetIdade(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine();

        Console.Write($"Digite o sexo da pessoa {i + 1}: ");
        vetorPessoa[i].SetSexo(Convert.ToChar(Console.ReadLine()!));
        Console.WriteLine();

        Console.Write($"Digite a altura da pessoa {i + 1}: ");
        vetorPessoa[i].SetAltura(Convert.ToDouble(Console.ReadLine()));

        Console.Clear();
    }
    return vetorPessoa;
}

void ExibirVetorPessoas(Pessoa[] vetorPessoa)
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"PESSOA {i + 1}:");
        Console.WriteLine(vetorPessoas[i].ToString());
    }
}

vetorPessoas = InserirPessoas(vetorPessoas);
ExibirVetorPessoas(vetorPessoas);

*/
#endregion


Pessoa pessoa = new Pessoa();

pessoa.SetNome("João");
pessoa.SetSobrenome("Silva");
pessoa.SetIdade(30);
pessoa.SetSexo('M');
pessoa.SetAltura(1.75);

pessoa.Endereco = new Endereco("Rua A", 123, "Bairro B", "12345-678", null, "Cidade C", "Estado D", "Pais E");

pessoa.mostrarInfo();
