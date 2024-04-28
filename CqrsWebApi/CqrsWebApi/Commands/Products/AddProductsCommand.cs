using CqrsMediatr.Models;
using MediatR;

namespace CqrsMediatr.Commands.Products
{
    public record AddProductsCommand(Product Product): IRequest<Product>;
}
