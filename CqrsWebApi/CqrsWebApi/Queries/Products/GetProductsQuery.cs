using CqrsMediatr.Models;
using MediatR;

namespace CqrsMediatr.Queries.Products
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
