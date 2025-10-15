// See https://aka.ms/new-console-template for more information

using SistemaNotificacoes;

List<Notificacao> ListaNotificacoes  = new List<Notificacao>();

ListaNotificacoes.Add(new Email());
ListaNotificacoes.Add(new SMS());
ListaNotificacoes.Add(new PushNotification());

foreach(Notificacao notificacao in ListaNotificacoes)
{
    notificacao.Enviar();
}