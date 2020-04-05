using demoNetCore.ViewModel.Catalog.Products;
using demoNetCore.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace demoNetCore.Application.Catolog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(PublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll(string languageId);
    }
}
