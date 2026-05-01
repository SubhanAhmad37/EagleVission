using EagleVission.Data;

namespace EagleVission.Interfaces
{
    public interface IProductRepository
    {
        Task<bool> AddProduct(Product product);
        Task<List<Product>> GetAllProducts();
    }
}
