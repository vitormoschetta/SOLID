using System.Collections.Generic;
using Ferindo.Models;

namespace Ferindo.Repositories
{
    public class Repository
    {
        private List<Product> list;
        public Repository()
        {
            list = new List<Product>();
        }
        public void Save(Product item)
        {
            list.Add(item);
        }

        public List<Product> GetAll()
        {
            return list;
        }
    }
}