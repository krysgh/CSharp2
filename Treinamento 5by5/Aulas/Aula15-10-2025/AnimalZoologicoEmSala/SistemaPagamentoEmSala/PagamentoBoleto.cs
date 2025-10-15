using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentoEmSala
{
    public class PagamentoBoleto : Pagamento
    {
        public override void ProcessarPagamento(decimal Valor, DateTime Data)
        {
            this.SetValor(Valor);
            this.SetDataDePagamento(Data);

            Console.WriteLine("Pagamento efetuado com Boleto! R$" + Valor);
            Console.WriteLine(Data);
        }
    }
}
