using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public abstract class Veiculo
    {

        private string Marca;
        private string Modelo;
        private int Ano;

        public string GetMarca()
        {
            return this.Marca;
        }

        public void SetMarca(string Marca)
        {
            this.Marca = Marca;
        }

        public string GetModelo()
        {
            return this.Modelo;
        }

        public void SetModelo(string Modelo)
        {
            this.Modelo = Modelo;
        }

        public int GetAno()
        {
            return this.Ano;
        }

        public void SetAno(int Ano)
        {
            this.Ano = Ano;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {this.Marca}\nModelo: {this.Modelo}\nAno: {this.Ano}");
        }


    }
}
