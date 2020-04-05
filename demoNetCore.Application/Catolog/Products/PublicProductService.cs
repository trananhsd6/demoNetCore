using demoNetCore.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using demoNetCore.ViewModel.Catalog.Products;
using demoNetCore.ViewModel.Common;

namespace demoNetCore.Application.Catolog.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly EShopDbContext _context;
        public PublicProductService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductViewModel>> GetAll(string languageId)
        {
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        where pt.LanguageId == languageId
                        select new { p, pt, pic };

            var data = await query.Select(n =>
                  new ProductViewModel()
                  {
                      Id = n.p.Id,
                      Name = n.pt.Name,
                      DateCreated = n.p.DateCreated,
                      Description = n.pt.Description,
                      Details = n.pt.Details,
                      LanguageId = n.pt.LanguageId,
                      OriginalPrice = n.p.OriginalPrice,
                      Price = n.p.Price,
                      SeoAlias = n.pt.SeoAlias,
                      SeoDescription = n.pt.SeoDescription,
                      SeoTitle = n.pt.SeoTitle,
                      Stock = n.p.Stock,
                      ViewCount = n.p.ViewCount
                  }
            ).ToListAsync();
            return data;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(PublicProductPagingRequest request)
        {
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        where pt.LanguageId == request.LanguageId
                        select new { p, pt, pic };



            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(p => p.pic.CategoryId == request.CategoryId);
            }


            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(n =>
                  new ProductViewModel()
                  {
                      Id = n.p.Id,
                      Name = n.pt.Name,
                      DateCreated = n.p.DateCreated,
                      Description = n.pt.Description,
                      Details = n.pt.Details,
                      LanguageId = n.pt.LanguageId,
                      OriginalPrice = n.p.OriginalPrice,
                      Price = n.p.Price,
                      SeoAlias = n.pt.SeoAlias,
                      SeoDescription = n.pt.SeoDescription,
                      SeoTitle = n.pt.SeoTitle,
                      Stock = n.p.Stock,
                      ViewCount = n.p.ViewCount
                  }
            ).ToListAsync();

            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pagedResult;
        }
    }
}
