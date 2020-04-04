using demoNetCore.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoNetCore.ViewModel.Catalog.Products
{
    public class PublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
