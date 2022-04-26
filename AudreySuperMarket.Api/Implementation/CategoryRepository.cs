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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationContext _context;

        public CategoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategoriess()
        {
            var category = await _context.Categories.Select(n => new CategoryDto()
            {
                Name = n.Name,
                IconCSS = n.IconCSS,
                Products = n.Products.Select(n => n.Name).ToList()

            }).ToListAsync();

            return category;

        }

        public async Task<IEnumerable<CategoryDto>> GetCategorybyId(int categoryId)
        {
            var category = await _context.Categories.Where(n => n.Id == categoryId).Select(n => new CategoryDto()
            {
                Name = n.Name,
                IconCSS = n.IconCSS,
                Products = n.Products.Select(n => n.Name).ToList()

            }).ToListAsync();
            return category;
        }
    }
}
