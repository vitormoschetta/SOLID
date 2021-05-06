using System;
using System.Collections.Generic;
using Aplicando.Contracts;
using Aplicando.Models;

namespace Aplicando.Repositories
{
    public class ProductRepositoryNew : IProductRepository
    {
        private List<Product> list;
        public ProductRepositoryNew()
        {
            list = new List<Product>();
        }
        
        public void Save(Product item)
        {
            if (item.Price == 0)
                throw new Exception("\nPreço do produto não pode ser 0\n");

            list.Add(item);
        }

        public List<Product> GetAll()
        {
            return list;
        }
    }
}