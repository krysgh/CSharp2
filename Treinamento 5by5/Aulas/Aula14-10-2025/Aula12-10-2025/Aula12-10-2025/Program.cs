// See https://aka.ms/new-console-template for more information


using Aula12_10_2025;

Pessoa pessoa = new Pessoa();

pessoa.SetNome("João");
pessoa.SetIdade(25);
pessoa.SetCpf("123.456.789-00");
pessoa.SetAltura(1.75);

Console.WriteLine(pessoa.GetNome());
Console.WriteLine(pessoa.GetIdade());
Console.WriteLine(pessoa.GetCpf());
Console.WriteLine(pessoa.GetAltura());

Console.ReadKey();