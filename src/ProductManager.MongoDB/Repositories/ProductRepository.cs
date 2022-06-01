using MongoDB.Driver;
using ProductManager.Domain.Contracts;
using ProductManager.Domain.Entities;

namespace ProductManager.MongoDB.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IMongoClient mongoClient, MongoSettings settings)
           : base(mongoClient, settings)
        {
        }  
    }
}
