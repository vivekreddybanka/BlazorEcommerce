﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blazorPWAEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]

        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await _productService.GetProductAsync();
            

            return  Ok(products);
        }
    }
}
