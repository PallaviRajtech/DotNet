using CqrsMediatr.Commands.Products;
using CqrsMediatr.Handlers.Products;
using CqrsMediatr.Models;
using CqrsMediatr.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

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
        [HttpGet("{Id:int}", Name = "GetProductById")]
        public IActionResult GetProductById(int Id)
        {
            return Ok(_mediatr.Send(new GetProductByIdQuery(Id)));
        }

        [HttpPost]
       public IActionResult AddProducts(Product product)
        {
            var addedProduct = _mediatr.Send(new AddProductsCommand(product));
            return CreatedAtRoute("GetProductById", new {Id = addedProduct.Id}, addedProduct);
        }




    }
}
