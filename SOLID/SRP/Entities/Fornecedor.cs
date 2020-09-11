using System;
using Solid.SRP.Services;
using Solid.Validacoes;

namespace Solid.SRP.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Função faz apenas o que seu nome expressa: modifica o nome.
        // Veja que para notificar a mudança no email, chama-se outra função. 
        // Esse é o princípio da responsabilidade única.
        public void ChangeName(string name)
        {
            ValidaArgumento.QuantidadeMinimaCaracteres(name, 3);

            Name = name;
            ServicoDeNotificacao.NotificarMudancaNome(name);
        }



    }
}