using System;

namespace Solid.SRP.Services
{
    public static class ServicoDeNotificacao
    {
        // Classe e Função possuiem única responsabilidade
        public static void NotificarMudancaNome(string name)
        {
            Console.WriteLine("Fornecedor Notificado");
        }
    }
}