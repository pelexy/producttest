using Ercas.Product.Service.Commands;
using Ercas.Product.Service.Queries;
using Ercas.Product.Service.Queries.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ercas.Product.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator mediator;

        public HomeController(IMediator mediator)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> Index()
        {
            return await mediator.Send(new GetAllProductsQuery());
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct([FromBody] CreateProductCommand request)
        {
            var result = await mediator.Send(request);
            return new JsonResult(result);
        }
    }
}