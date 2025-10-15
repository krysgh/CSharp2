using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public class Carro: Veiculo
    {

        private int NumeroDePortas;

        public int GetNumeroDePortas()
        {
            return this. NumeroDePortas;
        }

        public void SetNumeroDePortas(int numeroDePortas)
        {
            this.NumeroDePortas = numeroDePortas;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Numero de Portas: {this.NumeroDePortas}");
        }
    }
}
