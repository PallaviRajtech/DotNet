using CqrsMediatr.Models;
using CqrsMediatr.Queries.Products;
using CqrsMediatr.Repositories.Interface;
using MediatR;

namespace CqrsMediatr.Handlers.Products
{
    public class GetProductsByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository _productRepository;
        public GetProductsByIdHandler(IProductRepository productRepository) => _productRepository = productRepository;
        public async Task<Product?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductById(request.Id);
        }
    }
}
