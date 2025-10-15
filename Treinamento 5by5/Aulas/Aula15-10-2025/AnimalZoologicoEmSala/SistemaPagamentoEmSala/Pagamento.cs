using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentoEmSala
{
    public abstract class Pagamento
    {
        private decimal Valor {  get; set; }

        private DateTime DataDePagamento { get; set; }

        public void SetValor(decimal Valor)
        {
            this.Valor = Valor;
        }

        public void SetDataDePagamento(DateTime DataDePagamento)
        {
            this.DataDePagamento = DataDePagamento;
        }



        public abstract void ProcessarPagamento(decimal Valor, DateTime Data);

    }
}
