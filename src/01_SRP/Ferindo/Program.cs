using System;

namespace Ferindo
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Product A", 5.50m);
            product.Save(product);

            // Estamos ferindo o princípio de responsabilidade única na classe Product.
            // A classe é responsável pelo modelo do objeto e suas validações, mas não deveria ser responsável por 
            // persistir informações no banco de dados.
        }
    }
}
