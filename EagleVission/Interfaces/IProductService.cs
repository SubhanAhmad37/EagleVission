using EagleVission.Data;
using EagleVission.Models;

namespace EagleVission.Interfaces
{
    public interface IProductService
    {

        Task<bool> AddProduct(ProductModel product);
        Task<List<Product>> GetAllProducts();

    }
}
