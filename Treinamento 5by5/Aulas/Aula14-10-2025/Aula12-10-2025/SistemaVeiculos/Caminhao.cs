using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public class Caminhao: Veiculo
    {

        private double CapacidadeDeCarga;

        public double GetCapacidadeDeCarga()
        {
            return this.CapacidadeDeCarga;
        }

        public void SetCapacidadeDeCarga(double CapacidadeDeCarga)
        {
            this.CapacidadeDeCarga = CapacidadeDeCarga;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.Write($"Capacidade de Carga: {this.CapacidadeDeCarga}");
        }
    }
}
