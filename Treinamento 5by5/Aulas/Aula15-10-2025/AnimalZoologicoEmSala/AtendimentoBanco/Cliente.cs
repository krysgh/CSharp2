using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoBanco
{
    internal class Cliente
    {

        private string Nome { get; set; }

        private int Idade { get; set; }

        private bool EhPrioritario { get; set; }

        private Cliente Proximo { get; set; }

        public Cliente(string nome, int idade, bool ehPrioritario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.EhPrioritario = ehPrioritario;
            this.Proximo = null;
        }

        public string GetNome()
        {
            return this.Nome;
        }
        
        public Cliente GetProximo()
        {
            return this.Proximo;
        }
        public void SetProximo(Cliente proximo)
        {
            this.Proximo = proximo;
        }


    }
}
