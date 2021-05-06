using System;

namespace Aplicando
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Product A", 5.50m);
            var repository = new ProductRepository();
            repository.Save(product);

            // Agora estamos aplicando o SRP:
            // A classe Product representa o objeto de domínio e suas validações, e
            // a classe ProductRepository representa a camada de persistência de dados.
        }
    }
}
