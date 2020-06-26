using Ercas.Product.Service.Domain.Models;
using Ercas.Product.Service.Queries.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ercas.Product.Service.Domain.Interfaces.AppIRepo
{
    public interface IProductRepository
    {
        Task<CustomerProduct> Add(CustomerProduct product);

        Task<List<CustomerProduct>> GetAll();
    }
}
