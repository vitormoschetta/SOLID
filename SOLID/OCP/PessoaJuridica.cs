using System;
using Solid.Validacoes;

namespace Solid.SOLID.OCP
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string name, string cnpj)
            : base(name)
        {
            ValidaArgumento.NuloOuVazio(cnpj, "CNPJ inválido");

            CNPJ = cnpj;
        }

        public string CNPJ { get; set; }

        public override void ImprimePessoa()
        {
            Console.WriteLine("Nome: " + Nome + " / cnpj: " + CNPJ);
        }
    }
}