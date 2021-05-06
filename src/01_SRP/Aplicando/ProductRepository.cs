using System.Collections.Generic;

namespace Aplicando
{
    public class ProductRepository
    {
        private List<Product> list;
        public ProductRepository()
        {
            list = new List<Product>();
        }


        public void Save(Product product)
        {
            list.Add(product);
        }
    }
}