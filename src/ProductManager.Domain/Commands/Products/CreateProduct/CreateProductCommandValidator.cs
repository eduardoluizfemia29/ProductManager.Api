using FluentValidation;

namespace ProductManager.Domain.Commands.Products.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(product => product.Name)
                .NotEmpty()
                .WithMessage("Obrigatório informar o Nome do produto a ser inserido.")
                .MaximumLength(100)
                .WithMessage("O nome do produto não pode ultrapassar 100 caracteres");

            RuleFor(product => product.Description)
                .NotEmpty()
                .WithMessage("Obrigatório informar a Descrição do produto a ser inserido.");
        }
    }
}
