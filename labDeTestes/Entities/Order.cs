using labDeTestes.Entities;
using System.Text;

namespace labDeTestes.Entities
{
    class Order
    {
        public DateTime PurchaseTime { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime purchaseTime, Client client)
        {
            PurchaseTime = purchaseTime;
            Client = client;
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Client: " + Client.Name + " - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Momment: " + PurchaseTime.ToString("dd/MM/yyyy"));
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total: $" + Total().ToString("F2"));
            return sb.ToString();
        }
    }
}
