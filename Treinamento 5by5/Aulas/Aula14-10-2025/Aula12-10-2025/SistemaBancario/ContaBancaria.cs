using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class ContaBancaria
    {
        private double Saldo;
        private string Titular;

        public double GetSaldo()
        {
            return this.Saldo;
        }

        public void SetSaldo(double saldo)
        {
            this.Saldo = saldo;
        }

        public string GetTitular()
        {
            return this.Titular;
        }

        public void SetTitular(string titular)
        {
            this.Titular = titular;
        }

        public double Depositar(decimal valor)
        {
            return this.Saldo += Convert.ToDouble(valor);
        }

        public double Sacar(decimal valor)
        {
            if (Convert.ToDouble(valor) <= this.Saldo)
                this.Saldo -= Convert.ToDouble(valor);

            return this.Saldo;
        }
    }
}
