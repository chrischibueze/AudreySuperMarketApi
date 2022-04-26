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
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("get-all-products")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var result = await _productRepository.GetAllProducts();
                if (result == null)
                {
                    return BadRequest(new ResponseModel(ResponseCode.Error, "Not Found", null));
                }


                return Ok(new ResponseModel(ResponseCode.Ok, "all products", result));
            }
            catch (Exception)
            {


                return NotFound("Error retrieving data from the database");

            }


        }


        [HttpGet]
        [Route("get-by-id")]
        public async Task<IActionResult> GetProductById(int id)
        {
            try
            {
                var result = await _productRepository.GetProductbyId(id);
                if (result.Count() == 0)
                {
                    return BadRequest(new ResponseModel(ResponseCode.Error, "no product added with such id or please put a valid id", null));
                }

                return Ok(new ResponseModel(ResponseCode.Ok, "view product details", result));
            }
            catch (Exception)
            {
                return NotFound("Error retrieving data from the database");

            }
        }


    }
}
