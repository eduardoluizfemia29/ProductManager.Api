using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductManager.CrossCutting.Notification;
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
    }
}