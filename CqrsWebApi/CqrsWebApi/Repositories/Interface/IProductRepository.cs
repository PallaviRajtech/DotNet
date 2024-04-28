using CqrsMediatr.Models;

namespace CqrsMediatr.Repositories.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product?> GetProductById(int Id);
        Task<Product> AddProduct(Product product);


    }
}
