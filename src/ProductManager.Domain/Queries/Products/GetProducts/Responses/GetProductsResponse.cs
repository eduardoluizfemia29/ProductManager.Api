using System;

namespace ProductManager.Domain.Queries.Products.GetProducts.Responses
{
    public class GetProductsResponse
    {
        public string  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}