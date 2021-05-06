using System;
using Ferindo.Models;
using Ferindo.Repositories;

namespace Ferindo
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Product A", 5.50m);
            var repository = new Repository();
            repository.Save(product);

            var customer = new Customer("Fulano da Silva", "fulano@email.com");
            //repository.Save(customer);

            // Queremos usar o mesmo método Save do Repositório, porém o repositório não nos permite salvar um
            // 'Customer'. Ou seja, para implementar uma outra entidade precisamos ou adicionar um novo repositório,
            // especifico para Customer, ou refatorar o repositório que existe.
        }
    }
}
