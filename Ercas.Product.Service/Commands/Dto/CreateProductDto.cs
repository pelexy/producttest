﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ercas.Product.Service.Commands.Dto
{
    public class CreateProductDto
    {        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
