using AutoMapper;
using ProductManager.Domain.Entities;

namespace ProductManager.Domain.Commands.Products.CreateProduct
{
    public class CreateProductCommandProfile : Profile
    {
        public CreateProductCommandProfile()
        {
            CreateMap<CreateProductCommand, Product>();
        }
    }
}
