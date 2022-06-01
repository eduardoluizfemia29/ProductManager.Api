using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using ProductManager.Domain.Contracts;
using ProductManager.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManager.Domain.Commands.Products.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, string>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;
        private readonly ILogger<CreateProductCommandHandler> _logger;

        public CreateProductCommandHandler(IMapper mapper,
            IProductRepository repository,
            ILogger<CreateProductCommandHandler> logger)
        {
            _mapper = mapper;
            _repository = repository;
            _logger = logger;
        }

        public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"CreateProductCommandHandler was called Request.Name: {request.Name}");

            var product = _mapper.Map<Product>(request);

            await _repository.InsertOneAsync(product, cancellationToken);

            _logger.LogInformation("CreateProductCommandHandler end of execution.");

            return product.Id;
        }
    }
}
