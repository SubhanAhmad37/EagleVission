using EagleVission.Interfaces;
using EagleVission.Models;
using EagleVission.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EagleVission.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductService _productService { get; set; }
        public ProductController(IProductService productService)
        {

            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await _productService.GetAllProducts();
                return Ok(products);

            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductModel product_Mdl)
        {
            try
            {

                bool result = await _productService.AddProduct(product_Mdl);
                if (result) {

                    return Ok(new
                    {
                        success = true,
                        message = "Product added successfully"
                    });
                }
                else
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Failed to add product"
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
