using labDeTestes.Entities.Enums;
namespace labDeTestes.Entities
{
    class Product
    {
        public string? Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        
        public Product()
        {
        }

        public Product(string name, Category category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
