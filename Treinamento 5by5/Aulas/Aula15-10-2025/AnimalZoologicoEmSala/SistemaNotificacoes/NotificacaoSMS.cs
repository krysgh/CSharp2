using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotificacoes
{
    public class NotificacaoSMS: Notificacao
    {
        public override void Enviar(string mensagem)
        {
            base.Enviar(mensagem);
            Console.WriteLine("SMS enviado!");
        }
    }
}
