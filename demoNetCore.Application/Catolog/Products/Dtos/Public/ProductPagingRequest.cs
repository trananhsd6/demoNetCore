using demoNetCore.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoNetCore.Application.Catolog.Products.Dtos.Public
{
    public class ProductPagingRequest:PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
