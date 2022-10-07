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

        public override string ToString()
        {
            return "Product: "
                + Item.Name
                + " Category: "
                + Item.Category.ToString()
                + "\nPrice: $ "
                + Item.Price
                + ", Quantity: "
                + Quantity
                + "\nSub-Total: $ "
                + SubTotal().ToString("F2");
        }

    }
}
