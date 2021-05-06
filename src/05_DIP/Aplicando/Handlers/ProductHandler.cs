using Aplicando.Contracts;
using Aplicando.Models;

namespace Aplicando.Handlers
{
    public class ProductHandler
    {
        // Aqui não dependemos de uma implementação, mas de uma abstração, no caso uma interface (IProductRepository)
        // Veja que também não instanciamos qualquer classe concreta, mas recebemos instancias no construtor.
        // Dessa forma, podemos receber como instância qualquer classe que implemente a interface IProductRepository.
        private IProductRepository _repository;
        public ProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public void Save(Product product)
        {
            _repository.Save(product);
        }
    }
}