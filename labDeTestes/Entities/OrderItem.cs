using labDeTestes.Entities;

namespace labDeTestes.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Item { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Product item)
        {
            Quantity = quantity;
            Item = item;
        }

        public double SubTotal()
        {
            return Item.Price * Quantity;
        }

    }
}
