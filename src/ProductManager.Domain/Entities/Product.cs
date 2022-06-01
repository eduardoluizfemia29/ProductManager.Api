namespace ProductManager.Domain.Entities
{
    public class Product : EntityBase
    {
        public Product(string name, string description, int quantity)
            : base()
        {
            Name = name;
            Description = description;
            Quantity = quantity;
        }

        public Product(string id, string name, string description, int quantity)
            : base(id)
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
