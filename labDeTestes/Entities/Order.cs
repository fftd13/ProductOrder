using labDeTestes.Entities;

namespace labDeTestes.Entities
{
    class Order
    {
        public DateTime PurchaseTime { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime purchaseTime)
        {
            PurchaseTime = purchaseTime;
        }

        public double Total(Shipping fee)
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum + fee.DeliveryFee();
        }
    }
}
