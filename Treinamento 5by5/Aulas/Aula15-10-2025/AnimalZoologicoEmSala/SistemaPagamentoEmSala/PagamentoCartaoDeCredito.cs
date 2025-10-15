using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentoEmSala
{
    internal class PagamentoCartaoDeCredito : Pagamento
    {
        public override void ProcessarPagamento(decimal Valor, DateTime Data)
        {
            this.SetValor(Valor);
            this.SetDataDePagamento(Data);
            Console.WriteLine("Pagamento efetuado com Cartão de Crédito! R$" + Valor);
            Console.WriteLine(Data);
        }       
    }
}