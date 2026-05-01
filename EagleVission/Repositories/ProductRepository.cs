using EagleVission.Data;
using EagleVission.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EagleVission.Repositories
{
    public class ProductRepository : IProductRepository

    {
        public AppDbContext _context { get; set; }

        public ProductRepository(AppDbContext context)
        {
            _context = context;   
        }
        public async Task<bool> AddProduct(Product product)
        {
            try
            {
               await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public async Task<List<Product>> GetAllProducts()
        {

            try
            {
                var data =  await _context.Products.ToListAsync();
                return data;
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
