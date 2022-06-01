using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductManager.Api.Responses;
using ProductManager.CrossCutting.Notification;
using ProductManager.Domain.Commands.Products.CreateProduct;
using ProductManager.Domain.Queries.Products.GetProducts;
using System.Net;
using System.Threading.Tasks;

namespace ProductManager.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : BaseController<ProductsController>
    {
        public ProductsController(ILogger<ProductsController> logger, IMediator mediator, INotificationContext notificationContext)
            : base(logger, mediator, notificationContext)
        {
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return await CreateResponse(new GetProductsQuery(), HttpStatusCode.OK);

        }

        [HttpPost]
        public async Task<ActionResult<Response>> Post([FromBody] CreateProductCommand command)
        {
            return await CreateResponse(command, HttpStatusCode.OK);
        }
    }
}