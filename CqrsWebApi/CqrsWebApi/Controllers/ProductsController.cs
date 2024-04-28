using CqrsMediatr.Handlers.Products;
using CqrsMediatr.Models;
using CqrsMediatr.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatr.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IMediator _mediatr;

        public ProductsController(IMediator mediatr) => _mediatr = mediatr;
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_mediatr.Send(new GetProductsQuery()));
        }
        [HttpGet("Id")]
        public IActionResult GetProductById(int Id)
        {
            return Ok(_mediatr.Send(new GetProductByIdQuery(Id)));
        }



    }
}
