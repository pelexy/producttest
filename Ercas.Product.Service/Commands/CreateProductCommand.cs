using Ercas.Product.Service.Commands.Dto;
using Ercas.Product.Service.Domain.Interfaces;
using Ercas.Product.Service.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ercas.Product.Service.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public CreateProductDto CreateProductDto { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            private readonly IProductRepository productRepository;

            public CreateProductCommandHandler(IProductRepository productRepository)
            {
                this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            }

            public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var product = CustomerProduct.CreateProduct
            (
                request.CreateProductDto.Name,
                request.CreateProductDto.Description,
                request.CreateProductDto.Price
            );

                await productRepository.Add(product);                

                return product.Id;
            }
        }
    }
}
