using System;
using Aplicando.Models;
using Aplicando.Repositories;

namespace Aplicando
{
    class Program
    {
        static void Main(string[] args)
        {            
            var product = new Product("Product A", 5.50m);
            var repository = new ProductRepository();
            repository.Save(product);

            // Nossa abstração está na pasta 'Contracts'. Se quisermos adicionar, por exemplo, adicionar um 
            // repositorio para clientes, podemos utilizar interface IRepository. Não precisaremos alterar nada nela.
            // Nosso código está aberta para implementações/extensão, e fechado para modificações.
        }
    }
}
