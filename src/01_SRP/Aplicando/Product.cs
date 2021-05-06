using System;

namespace Aplicando
{
    public class Product
    {
        public Product(string name, decimal price)
        {   
            Id = Guid.NewGuid();
            Name = name;
            Price = price;

            Validate();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Nome do produto precisa ser informado!");
        }     
    }
}