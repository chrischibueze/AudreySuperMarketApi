using AudreySuperMarket.Api.Entities;
using AudreySuperMarket.Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudreySuperMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;


        }

        [HttpGet("get-all-categories")]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                var result = await _categoryRepository.GetAllCategoriess();
                if (result == null)
                {
                    return BadRequest(new ResponseModel(ResponseCode.Error, "Not Found", null));
                }


                return Ok(new ResponseModel(ResponseCode.Ok, "all categories", result));
            }
            catch (Exception)
            {


                return NotFound("Error retrieving data from the database");

            }
        }


        [HttpGet]
        [Route("get-by-id")]
        public async Task<IActionResult> GetProductById(int categoryId)
        {
            try
            {
                var result = await _categoryRepository.GetCategorybyId(categoryId);

                if (result.Count() == 0)
                {
                    return BadRequest(new ResponseModel(ResponseCode.Error, "no category added with such id or please put a valid id", null));
                }

                return Ok(new ResponseModel(ResponseCode.Ok, "view category details", result));
            }
            catch (Exception)
            {
                return NotFound("Error retrieving data from the database");

            }
        }


    }
}
