using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_10_2025
{
    public class Pessoa
    {
        public int Idade;
        public string Nome;
        public string Cpf;
        public double Altura;


        public Pessoa()
        {

        }

        public void SetIdade(int Idade)
        {
            this.Idade = Idade;
        }

        public int GetIdade()
        {
            return this.Idade;
        }
        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string GetNome()
        {
            return this.Nome;
        }
        public void SetCpf(string Cpf)
        {
            this.Cpf = Cpf;
        }

        public string GetCpf()
        {
            return this.Cpf;
        }
        public void SetAltura(double Altura)
        {
            this.Altura = Altura;
        }

        public double GetAltura()
        {
            return this.Altura;
        }

    }
}