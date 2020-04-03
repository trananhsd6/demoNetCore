using demoNetCore.Application.Catolog.Products.Dtos;
using demoNetCore.Application.Catolog.Products.Dtos.Public;
using demoNetCore.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace demoNetCore.Application.Catolog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(ProductPagingRequest request);
    }
}
