using labDeTestes.Entities;
using labDeTestes.Entities.Enums;

namespace labDeTestes.Entities
{
    class Shipping
    {
        public DeliverService Deliverservice { get; set; }
        
        public Shipping() { }

        public Shipping(DeliverService deliverservice)
        {
            Deliverservice = deliverservice;
        }

        public double DeliveryFee()
        {
            double fee = 0;
                        
            if(Deliverservice == DeliverService.Commom)
            {
                fee = 15.0;
            }
            else
            {
                fee = 25.50;
            }

            return fee;
        }

        public DateTime OrderArrival(DateTime purchasetime)
        {
            int days = 0;
            if (Deliverservice == DeliverService.Commom)
            {
                days = 26;
            }
            else
            {
                days = 12;
            }

            return purchasetime.AddDays(days);
        }
    }
}
