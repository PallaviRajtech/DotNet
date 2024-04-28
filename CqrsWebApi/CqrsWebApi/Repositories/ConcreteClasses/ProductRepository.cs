using CqrsMediatr.Models;
using CqrsMediatr.Repositories.Interface;
using System.Reflection;

namespace CqrsMediatr.Repositories.ConcreteClasses
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1" },
            new Product { Id = 2, Name = "Product 2" },
            new Product { Id = 3, Name = " Product 3" }
        };
        }
        public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult(_products);

        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }

        public Task<Product?> GetProductById(int Id)
        {
            return Task.FromResult(_products.FirstOrDefault(x => x.Id == Id));
        }
    }
}
