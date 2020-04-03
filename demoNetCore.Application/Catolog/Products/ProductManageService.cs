using demoNetCore.Application.Catolog.Products.Dtos;
using demoNetCore.Application.Catolog.Products.Dtos.Manage;
using demoNetCore.Application.Dtos;
using demoNetCore.Data.EF;
using demoNetCore.Data.Entities;
using demoNetCore.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoNetCore.Application.Catolog.Products
{
    public class ProductManageService : IManageProductService
    {
        private readonly EShopDbContext _context;
        public ProductManageService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoDescription = request.SeoDescription,
                        SeoAlias = request.SeoAlias,
                        SeoTitle = request.SeoTitle,
                        LanguageId = request.LanguageId
                    }
                }
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productID)
        {
            var product = await _context.Products.FindAsync(productID);
            if (product == null)
            {
                throw new demoNetCoreException($"Cannot find a product:{productID}");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(ProductPagingRequest request)
        {
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pt, pic };


            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.pt.Name.Contains(request.Keyword));
            }
            if (request.CatogoryIds.Count > 0)
            {
                query = query.Where(p => request.CatogoryIds.Contains(p.pic.CategoryId));
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

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            var productTranslations = await _context.ProductTranslations.FirstOrDefaultAsync(n => n.ProductId == request.Id
            && n.LanguageId == request.LanguageId);
            if (product == null || productTranslations == null) throw new demoNetCoreException($"Cannot find a product:{request.Id}");

            productTranslations.Name = request.Name;
            productTranslations.SeoAlias = request.SeoAlias;
            productTranslations.SeoTitle = request.SeoTitle;
            productTranslations.SeoDescription = request.SeoDescription;
            productTranslations.Description = request.Description;
            productTranslations.Details = request.Details;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new demoNetCoreException($"Cannot find a product:{productId}");

            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new demoNetCoreException($"Cannot find a product:{productId}");

            product.Stock += addedQuantity;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
