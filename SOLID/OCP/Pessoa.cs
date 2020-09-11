using System;
using Solid.Validacoes;

namespace Solid.SOLID.OCP
{
    // Podemos extender seu uso  para pessas Física e Jurídica, por exemplo,
    // sem modificar a classe base. 
    public abstract class Pessoa
    {
        public Pessoa(string nome)
        {
            ValidaArgumento.QuantidadeMinimaCaracteres(nome, 3);

            Nome = nome;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }



        // Este método será implementado nas classes derivadas.
        // Método abstrato é utilizado quando sua implementação varia de acordo com as classes derivadas.
        // Dessa forma, a classe base não será alterada. 
        // Aberta para extensão. Fechada para modificação.
        public abstract void ImprimePessoa();
    }
}