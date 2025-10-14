using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios
{
    public abstract class Funcionario
    {
        private string Nome {  get; set; }
        private double SalarioBase { get; set; }



        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }


        public double GetSalarioBase()
        {
            return this.SalarioBase;
        }

        public void SetSalarioBase(double salarioBase)
        {
            this.SalarioBase = salarioBase;
        }


        public abstract double CalcularSalarioFinal();

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {this.GetNome()}");
            Console.WriteLine($"Salário Base: {this.GetSalarioBase()}");
        }




    }
}
