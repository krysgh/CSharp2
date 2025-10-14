using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PessoasNoVetor
{
    public class Endereco
    {

        public string Logradouro { get; set; }

        public int Numero;
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public Endereco(string Logradouro, int Numero, string Bairro, string CEP, string? Complemento,string Cidade, string Estado, string Pais)
        {
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Bairro = Bairro;
            this.CEP = CEP;
            this.Complemento = Complemento;
            this.Cidade = Cidade;
            this.Estado = Estado;
            this.Pais = Pais;
        }


        public void mostrarEndereco()
        {
            Console.WriteLine($"Endereco: {Logradouro}, {Numero}");
            Console.WriteLine($"Bairro: {Bairro}");
            Console.WriteLine($"CEP: {CEP}");
            if(Complemento != null)
            {
                Console.WriteLine($"Complemento: {Complemento}");
            }
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"País: {Pais}");
        }

    }
}
