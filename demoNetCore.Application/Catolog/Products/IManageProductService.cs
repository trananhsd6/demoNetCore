using demoNetCore.ViewModel.Catalog.Products;
using demoNetCore.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace demoNetCore.Application.Catolog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productID);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task<ProductViewModel> GetById(int productId,string languageId);
        Task AddViewCount(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(ManageProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImages(int imageId, string caption,bool isDefault);
        Task<List<ProductImageViewMode>> GetListImage(int productId);
    }
}
