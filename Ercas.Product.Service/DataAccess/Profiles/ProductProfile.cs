using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ercas.Product.Service.Commands.Dto;
using Ercas.Product.Service.Domain.Models;
using Ercas.Product.Service.Queries.Dto;

namespace Ercas.Product.Service.DataAccess.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductDto, CustomerProduct>();
            CreateMap<CustomerProduct, ProductDto>();
            CreateMap<ProductDto, CustomerProduct>();

        }
    }
}
