using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using ProductManager.CrossCutting.Notification;
using ProductManager.Domain.Contracts;
using ProductManager.Domain.Queries.Products.GetProducts.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManager.Domain.Queries.Products.GetProducts
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<GetProductsResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;
        private readonly INotificationContext _notificationContext;
        private readonly ILogger<GetProductsQueryHandler> _logger;

        public GetProductsQueryHandler(IMapper mapper,
            IProductRepository repository,
            INotificationContext notificationContext,
            ILogger<GetProductsQueryHandler> logger)
        {
            _mapper = mapper;
            _repository = repository;
            _notificationContext = notificationContext;
            _logger = logger;
        }

        public async Task<IEnumerable<GetProductsResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("GetProductsQueryHandler was called");

            var products = await _repository.FindAsync(cancellationToken);

            if (!products.Any())
            {
                _notificationContext.AddNotification("Nenhum Produto Encontrado", "Não existe nenhum produto no Banco de Dados :(");
                return default;
            }

            _logger.LogInformation("GetProductsQueryHandler end of execution");

            return _mapper.Map<IEnumerable<GetProductsResponse>>(products);
        }
    }
}
