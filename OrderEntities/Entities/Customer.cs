﻿namespace OrderEntities.Entities
{
    public class Customer
    {
        public long Id { get; set; }
        public long RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}