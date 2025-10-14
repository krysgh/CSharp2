using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentos
{
    public class PagamentoBoleto : Pagamento
    {
        public override double ProcessarPagamento()
        {
            return base.GetValor();
        }
    }
}
