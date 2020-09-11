using System;
using Solid.SRP.Contracts;
using Solid.SRP.Entities;

namespace Solid.SRP.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public void Salvar(Fornecedor fornecedor)
        {
            Console.WriteLine("Fornecedor {0} salvo", fornecedor.Name);
        }
    }
}