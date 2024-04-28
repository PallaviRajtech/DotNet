using CqrsMediatr.Models;

namespace CqrsMediatr.Repositories.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task AddProduct(Product product);
        Task<Product?> GetProductById(int Id);


    }
}
