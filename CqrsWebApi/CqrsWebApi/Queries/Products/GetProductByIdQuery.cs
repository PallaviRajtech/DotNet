using CqrsMediatr.Models;
using MediatR;

namespace CqrsMediatr.Queries.Products
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>
    {

    }

}
