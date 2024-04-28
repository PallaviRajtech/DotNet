using CqrsMediatr.Models;
using CqrsMediatr.Queries.Products;
using CqrsMediatr.Repositories.Interface;
using MediatR;

namespace CqrsMediatr.Handlers.Products
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductsHandler(IProductRepository productRepository) => _productRepository = productRepository;
        public Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return _productRepository.GetAllProducts();
        }
    }
}
