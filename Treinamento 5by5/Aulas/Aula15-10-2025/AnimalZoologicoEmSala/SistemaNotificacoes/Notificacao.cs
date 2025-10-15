using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotificacoes
{
    public abstract class Notificacao
    {
        public virtual void Enviar(string mensagem)
        {
            Console.WriteLine($"Enviando Notificação: {mensagem}");
        }

    }
}
