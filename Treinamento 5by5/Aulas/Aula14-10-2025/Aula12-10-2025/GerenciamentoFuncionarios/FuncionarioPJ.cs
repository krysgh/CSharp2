using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GerenciamentoFuncionarios
{
    public class FuncionarioPJ: Funcionario
    {
        private int HorasTrabalhadas;
        private double ValorHora;

        public int GetHorasTrabalhadas()
        {
            return this.HorasTrabalhadas;
        }

        public void SetHorasTrabalhadas(int HorasTrabalhadas)
        {
            this.HorasTrabalhadas = HorasTrabalhadas;
        }

        public double GetValorHora()
        {
            return this.ValorHora;
        }

        public void SetValorHora(double ValorHora)
        {
            this.ValorHora = ValorHora;
        }

        public override double CalcularSalarioFinal()
        {
            return this.HorasTrabalhadas * this.ValorHora + base.GetSalarioBase();
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Horas Trabalhadas: {this.HorasTrabalhadas}");
            Console.WriteLine($"Valor Hora: {this.ValorHora}");
            Console.WriteLine($"Salário Total: {this.CalcularSalarioFinal()}");
        }

    }
}
