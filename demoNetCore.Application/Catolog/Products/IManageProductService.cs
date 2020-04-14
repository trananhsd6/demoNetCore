using demoNetCore.ViewModel.Catalog.ProductImages;
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
        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImage( int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewMode>> GetListImages(int productId);
        Task<ProductImageViewMode> GetImageById(int imageId);
    }
}
