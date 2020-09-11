using System;
using Solid.Validacoes;

namespace Solid.SOLID.OCP
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string name, string cpf)
            : base(name)
        {
            ValidaArgumento.NuloOuVazio(cpf, "CPF inválido");

            CPF = cpf;
        }

        public string CPF { get; set; }

        public override void ImprimePessoa()
        {
            Console.WriteLine("Nome: " + Nome + " / CPF: " + CPF);
        }
    }
}