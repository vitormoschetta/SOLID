using Aplicando.Handlers;
using Aplicando.Models;
using Aplicando.Repositories;

namespace Aplicando
{
    class Program
    {
        static void Main(string[] args)
        {            
            var product = new Product("Product A", 0);  

            var repository = new ProductRepository();
            var repositoryNew = new ProductRepositoryNew();

            // Instanciamos o handler passando uma instância do repositório que queremos utilizar. 
            // Podemos passar ao Handler qualquer classe que implemente a interface IProductRepository.
            var handler = new ProductHandler(repository);                        

            handler.Save(product);        


            // Aqui passamos um outro repositório que implementa IProductRepository, que inclusive haje de forma diferente.
            handler = new ProductHandler(repositoryNew);

            handler.Save(product);        
            

            // Como funciona a injeção de dependência para Controllers? Como não instanciamos um Controller, a injeção de dependência 
            // é configurada pelo próprio framework. No caso do Dot NET Core, na classe Startup isso é configurado.
        }
    }
}
