using Ercas.Product.Service.Domain.Interfaces;
using Ercas.Product.Service.Domain.Models;
using Ercas.Product.Service.Queries.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ercas.Product.Service.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<CustomerProduct> Add(CustomerProduct product)
        {
            await context.CustomerProducts.AddAsync(product);
            await context.SaveChangesAsync();
            return product;
        }

        public async Task<List<CustomerProduct>> GetAll()
        {
            return await context
               .CustomerProducts
               .ToListAsync();
        }
       
    }
}
