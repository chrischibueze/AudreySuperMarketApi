using AudreySuperMarket.Api.Entities;
using AudreySuperMarket.Api.Interfaces;
using AudreySuperMarket.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using SupermarketWebApi.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudreySuperMarket.Api.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _context;

        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = await _context.Products.Select(n => new ProductDto()
            {
                Id = n.Id,
                Name = n.Name,
                ImageURL = n.ImageURL,
                Qty = n.Qty,
                Description = n.Description,
                CategoryId = n.CategoryId,
                Price = n.Price,
                CategoryName = n.Category.Name

            }).ToListAsync();

            return products;
        }

        public async Task<IEnumerable<ProductDto>> GetProductbyId(int productId)
        {
            var result = await _context.Products.Where(n => n.Id == productId).Select(n => new ProductDto()
            {
                Id = n.Id,
                Name = n.Name,
                ImageURL = n.ImageURL,
                Qty = n.Qty,
                Description = n.Description,
                CategoryId = n.CategoryId,
                Price = n.Price,
                CategoryName = n.Category.Name

            }).ToListAsync();
            return result;
        }
    }
}

