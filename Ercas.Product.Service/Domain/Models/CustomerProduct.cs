using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ercas.Product.Service.Domain.Models
{
    public class CustomerProduct
    {    

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public decimal Price { get; private set; }

        private CustomerProduct()
        { }

        private CustomerProduct(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public static CustomerProduct CreateProduct(string name, string description, decimal price)
        {
            return new CustomerProduct(name, description, price);
        }
    }
}
