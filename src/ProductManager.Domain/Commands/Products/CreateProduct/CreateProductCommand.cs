using MediatR;

namespace ProductManager.Domain.Commands.Products.CreateProduct
{
    public class CreateProductCommand : IRequest<string>
    {
        private CreateProductCommand()
        {

        }

        public CreateProductCommand(string name, string description, int quantity)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
        }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}

