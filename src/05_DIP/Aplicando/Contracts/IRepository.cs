using System.Collections.Generic;
using Aplicando.Models;

namespace Aplicando.Contracts
{
    public interface IProductRepository
    {
        void Save(Product item);
        List<Product> GetAll();
    }
}