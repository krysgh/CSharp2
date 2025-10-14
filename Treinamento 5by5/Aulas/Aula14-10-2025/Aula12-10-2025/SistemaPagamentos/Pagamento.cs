using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentos
{
    public abstract class Pagamento
    {
        private double Valor;
        private DateTime DataPagamento;

        public double GetValor()
        {
            return this.Valor;
        }

        public void SetValor(double valor)
        {
            this.Valor = valor;
        }

        public DateTime GetDataPagamento()
        {
            return this.DataPagamento;
        }

        public void SetDataPagamento(DateTime dataPagamento)
        {
            this.DataPagamento = dataPagamento;
        }

        public abstract double ProcessarPagamento();

        public string ToString()
        {
            return $"Valor Total:R$ {this.ProcessarPagamento():F2}\nData de Pagamento: {this.DataPagamento:d}";
        }


    }
}
