using Ercas.Product.Service.DataAccess;
using Ercas.Product.Service.Domain.Interfaces;
using Ercas.Product.Service.Domain.Models;
using Ercas.Product.Service.Queries.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ercas.Product.Service.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductDto>>
        {
            private readonly IProductRepository productRepository;

            public GetAllProductsQueryHandler(IProductRepository productRepository)
            {
                this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            }

            public async Task<IEnumerable<ProductDto>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
            {
                var result = await productRepository.GetAll();
                return result.Select(p => new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                }).ToList();
            }

        }
    }
}
