using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public class Moto: Veiculo
    {

        private bool CapaceteObrigatorio;

        public bool GetCapaceteObrigatorio()
        {
            return this.CapaceteObrigatorio;
        }

        public void SetCapaceteObrigatorio(bool CapaceteObrigatorio)
        {
            this.CapaceteObrigatorio = CapaceteObrigatorio;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.Write($"Capacete Obrigatório: ");

            if (CapaceteObrigatorio)
                Console.WriteLine("Sim");
            else
                Console.WriteLine("Não");
        }
    }
}
