using CqrsMediatr.Commands.Products;
using CqrsMediatr.Models;
using CqrsMediatr.Repositories.Interface;
using MediatR;

namespace CqrsMediatr.Handlers.Products
{
    public class AddProductHandler : IRequestHandler<AddProductsCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public AddProductHandler(IProductRepository productRepository) => _productRepository = productRepository;
        public async Task<Product> Handle(AddProductsCommand request, CancellationToken cancellationToken)
        {
            return await _productRepository.AddProduct(request.Product);
        }
    }
}
