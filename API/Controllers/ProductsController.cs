using System;
using Infraestructure.Data;
using Microsoft.AspNetCore.Mvc;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
{
        
        private readonly StoreContext context;

        public ProductsController(StoreContext context)
        {
            this.context = context;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await context.Products.ToListAsync();
        }

        // GET: api/products/{id}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await context.Products.FindAsync(id);
            if (product == null) return NotFound();
            return product;
        }

        // POST: api/products
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
            return product;
        }
    }

