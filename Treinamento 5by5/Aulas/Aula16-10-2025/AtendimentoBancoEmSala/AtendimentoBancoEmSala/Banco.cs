using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoBancoEmSala
{
    public class Banco
    {
        public FilaCliente FilaNormal { get; set; }

        public FilaCliente FilaPrioritaria { get; set; }

        public int contador {  get; set; }

        public Banco()
        {
            this.FilaNormal = new FilaCliente();
            this.FilaPrioritaria = new FilaCliente();
            this.contador = 0;
        }

        public Cliente AtenderCliente()
        {
            if (this.FilaNormal.Vazia() && this.FilaPrioritaria.Vazia())
                return null;

            else
            {
                if (this.FilaPrioritaria.Vazia())
                {
                    return FilaNormal.Desenfileirar();
                }
                else if (this.FilaNormal.Vazia())
                {
                    return FilaPrioritaria.Desenfileirar();
                }
                else
                {
                    if(contador % 3 == 0)
                    {
                        this.contador++;
                        return FilaPrioritaria.Desenfileirar();
                        
                    }
                    else
                    {
                        this.contador++;
                        return FilaNormal.Desenfileirar() ;
                    }
                }
            }
        }

    }
}
