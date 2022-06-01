using AutoMapper;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Queries.Products.GetProducts.Responses;

namespace ProductManager.Domain.Queries.Products.GetProducts
{
    public class GetProductsQueryProfile : Profile
    {
        public GetProductsQueryProfile()
        {
            CreateMap<Product, GetProductsResponse>();
        }
    }
}
