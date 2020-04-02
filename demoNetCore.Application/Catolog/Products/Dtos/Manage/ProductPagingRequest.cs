using demoNetCore.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoNetCore.Application.Catolog.Products.Dtos.Manage
{
    public class ProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CatogoryIds { get; set; }
    }
}
