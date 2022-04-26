using AudreySuperMarket.Api.Entities;
using AudreySuperMarket.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudreySuperMarket.Api.Interfaces
{
    public interface IProductRepository
    {
        public Task<IEnumerable<ProductDto>> GetAllProducts();

        public Task<IEnumerable<ProductDto>> GetProductbyId(int productId);

    }
}
