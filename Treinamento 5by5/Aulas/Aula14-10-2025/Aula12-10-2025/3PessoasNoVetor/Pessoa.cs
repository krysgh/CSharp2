using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PessoasNoVetor
{
    public class Pessoa
    {
        // o tipo pessoa deve conter nome, idade, sexo,altura e sobrenome.

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public double Altura { get; set; }
        public Endereco Endereco { get; set; }

        public Pessoa()
        {

        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string GetSobrenome()
        {
            return this.Sobrenome;
        }

        public void SetSobrenome(string Sobrenome)
        {
            this.Sobrenome = Sobrenome;
        }

        public int GetIdade()
        {
            return this.Idade;
        }

        public void SetIdade(int Idade)
        {
            this.Idade = Idade;
        }

        public char GetSexo()
        {
            return this.Sexo;
        }

        public void SetSexo(char Sexo)
        {
            this.Sexo = Sexo;
        }

        public double GetAltura()
        {
            return this.Altura;
        }

        public void SetAltura(double Altura)
        {
            this.Altura = Altura;
        }

        public void mostrarInfo() {

            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Sobrenome: {this.Sobrenome}");
            Console.WriteLine($"Idade: {this.Idade}");
            Console.WriteLine($"Sexo: {this.Sexo}");
            Console.WriteLine($"Altura: {this.Altura}");
            this.Endereco.mostrarEndereco();

        }


    }
}
