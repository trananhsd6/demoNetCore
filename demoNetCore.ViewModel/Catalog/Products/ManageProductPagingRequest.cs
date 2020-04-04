using demoNetCore.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoNetCore.ViewModel.Catalog.Products
{
    public class ManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CatogoryIds { get; set; }
    }
}
