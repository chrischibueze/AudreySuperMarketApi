using AudreySuperMarket.Api.Entities;
using AudreySuperMarket.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudreySuperMarket.Api.Interfaces
{
    public interface ICategoryRepository
    {
        public Task<IEnumerable<CategoryDto>> GetAllCategoriess();


        public Task<IEnumerable<CategoryDto>> GetCategorybyId(int Id);
    }
}
