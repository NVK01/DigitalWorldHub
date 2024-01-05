using DigitalWorldHub.Core.Entities;
using DigitalWorldHub.Infrastructure;
using DigitalWorldHub.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DigitalWorldHub.Server.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _reposit;
        public ProductsController(IProductRepository reposit)
        {
            _reposit = reposit;
        }

        [HttpGet("controller")]
       
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _reposit.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("controller/{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            
            return await _reposit.GetProductByIdAsync(id);
        }
    }
}
