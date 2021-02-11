using System;

namespace OrderEntities.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public string Number { get; set; }

        public DateTime PlaceOn { get; set; }
        public long CustomerId { get; set; }

        public long CakeId { get; set; }
        public string Cake { get; set; }

        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}
