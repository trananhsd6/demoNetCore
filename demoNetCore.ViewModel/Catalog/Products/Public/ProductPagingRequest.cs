using demoNetCore.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoNetCore.ViewModel.Catalog.Products.Public
{
    public class ProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
