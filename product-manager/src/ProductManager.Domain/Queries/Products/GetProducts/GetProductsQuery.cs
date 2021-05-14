using MediatR;
using ProductManager.Domain.Queries.Products.GetProducts.Responses;
using System.Collections.Generic;

namespace ProductManager.Domain.Queries.Products.GetProducts
{
    public class GetProductsQuery : IRequest<IEnumerable<GetProductsResponse>>
    {

    }
}