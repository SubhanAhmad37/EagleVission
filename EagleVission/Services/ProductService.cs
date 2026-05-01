using EagleVission.Data;
using EagleVission.Interfaces;
using EagleVission.Models;

namespace EagleVission.Services
{
    public class ProductService : IProductService
    {
        private  IProductRepository _ProductRepository;

        public ProductService(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        public async Task<bool> AddProduct(ProductModel product)
        {
            Product product_Mdl = new Product()
            {
                Id = product.id,
                Name = product.name,
                CompanyName = product.companyName,
                Category = product.category,
                BarCodeNo = product.barCodeNo,
                PurchasePrice = product.purchasePrice,
                SellPrice = product.sellPrice,
                BulkPrice = product.bulkPrice ?? 0,
                Stock = product.stock,
                State = product.state,
                Image = product.image,
                Remarks = product.remarks,
            };

            var result = await _ProductRepository.AddProduct(product_Mdl);

            return result;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _ProductRepository.GetAllProducts();
        }
    }
}
