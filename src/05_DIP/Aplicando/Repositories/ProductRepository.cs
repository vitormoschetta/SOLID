using System;
using System.Collections.Generic;
using Aplicando.Contracts;
using Aplicando.Models;

namespace Aplicando.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> list;
        public ProductRepository()
        {
            list = new List<Product>();
        }
        
        public void Save(Product item)
        {
            list.Add(item);
            Console.WriteLine("\nSalvo com sucesso!\n");
        }

        public List<Product> GetAll()
        {
            return list;
        }
    }
}