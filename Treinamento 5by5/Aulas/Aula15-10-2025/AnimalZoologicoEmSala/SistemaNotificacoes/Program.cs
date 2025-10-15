// See https://aka.ms/new-console-template for more information

using SistemaNotificacoes;

Notificacao[] notificacoes = new Notificacao[3];

notificacoes[0] = new NotificacaoSMS();
notificacoes[1] = new NotificacaoEmail();
notificacoes[2] = new NotificacaoPush();

foreach(var notificacao in notificacoes)
{
    notificacao.Enviar("Olá, esta é uma notificação importante ");
}